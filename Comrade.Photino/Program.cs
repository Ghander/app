﻿using System.Drawing;
using Comrade.UI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Photino.Blazor;
using PhotinoNET;

namespace Comrade.Photino
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var appBuilder = PhotinoBlazorAppBuilder.CreateDefault(args);
            appBuilder.Services.ConfigureUIServices();
            appBuilder.Services.AddLogging();
            appBuilder.RootComponents.Add<App>("app");
            appBuilder.RootComponents.Add<HeadOutlet>("head::after");

            var app = appBuilder.Build();

            // customize window.
            app.MainWindow
                .SetResizable(true)
                .SetZoom(0)
                // .SetIconFile("favicon.ico")
                .SetTitle("Comrade");

            app.MainWindow.Center();
            Size? size = null;
            Size? lastAcceptedSize = null;

            app.MainWindow.WindowSizeChangedHandler += (sender, e) =>
            {
                try
                {
                    PhotinoWindow? window = sender as PhotinoWindow;

                    if (size == null)
                    {
                        size = e;
                    }
                    else
                    {
                        double zoomx = (double) e.Width / ((Size) size).Width * 100;
                        double zoomy = (double) e.Height / ((Size) size).Height * 100;
                        double zoom = Math.Min(zoomx, zoomy);
                        if (zoom < 75 && lastAcceptedSize is not null)
                        {
                            window.SetSize(lastAcceptedSize.Value);
                        }
                        else
                        {
                            lastAcceptedSize = window.Size;
                            window.SetZoom((int) zoom);
                        }
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(e);
                }
            };
            AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
            {
                app.MainWindow.ShowMessage("Fatal exception", error.ExceptionObject.ToString());
            };

            app.Run();
        }
    }
}