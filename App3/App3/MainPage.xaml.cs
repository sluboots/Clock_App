using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;


namespace App3
{
    public partial class MainPage : ContentPage
    {
      
        SKPaint dotsNumberPaint = new SKPaint
        {
            Style = SKPaintStyle.StrokeAndFill,
            Color = SKColors.DarkRed,
        };
        SKPaint backgroundPaint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            Color = SKColors.Black
        };

        void NumberChoose(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            // получаем текущую поверхность из аргументов
            SKSurface surface = args.Surface;
            // Получаем холст на котором будет рисовать
            SKCanvas canvas = surface.Canvas;

            canvas.DrawPaint(backgroundPaint);

            string name = "";
            var canvasInfo = (SKCanvasView)sender;
            var grid = canvasInfo.Parent;

            string[] canvasNames = { "Hour_First", "Hour_Second", "Minute_First",
                                     "Minute_Second", "Second_First", "Second_Second", "DotsNumber1", "DotsNumber2"};

            foreach (var canvasName in canvasNames)
            {
                var canvasElem = (SKCanvasView)grid.FindByName(canvasName);
                if (canvasElem.Id == canvasInfo.Id)
                {
                    name = canvasName;
                    break;
                }
            }

            int number;
            DateTime dateTime = DateTime.Now;
            switch (name)
            {
                case "Hour_First":
                    number = dateTime.Hour / 10;
                    break;
                case "Hour_Second":
                    number = dateTime.Hour % 10;
                    break;
                case "Minute_First":
                    number = dateTime.Minute / 10;
                    break;
                case "Minute_Second":
                    number = dateTime.Minute % 10;
                    break;
                case "Second_First":
                    number = dateTime.Second / 10;
                    break;
                case "Second_Second":
                    number = dateTime.Second % 10;
                    break;
                case "DotsNumber1":
                    number = -2;
                    break;
                case "DotsNumber2":
                    number = -2;
                    break;
                default:
                    number = -1;
                    break;
            }

            DrawNumber(canvas, info.Width, info.Height, number);
        }

        void DrawNumber(SKCanvas canvas, int width, int height, int number)
        {
            switch (number)
            {
                case 0:
                    //upper line
                    canvas.DrawCircle(width - 10 * 3, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);

                    //left line
                   

                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    // right line
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    // lower line
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    break;
                case 1:
                    

                    //right line
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    break;
                case 2:

                    // upper line 
                    canvas.DrawCircle(width - 10 * 3, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);

                    //right line 
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    

                    //left line 
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    //1st lower line
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20*2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20*2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20*2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20*2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20*2, 10, dotsNumberPaint);

                    //2nd lower line
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    break;
                case 3:
                    
                    // upper line 
                    canvas.DrawCircle(width - 10 * 3, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);

                    //right line 
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                   

                    //left line 


                    canvas.DrawCircle(width - 10, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    //1st lower line
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);

                    //2nd lower line
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    break;


                case 4:
                    //right line 
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    //lower line 
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);


                    //left line
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    break;


                case 5:
                    //upper line
                    canvas.DrawCircle(width - 10 * 3, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);

                    //left line
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);


                    //middle line
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);

                    //right line
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    //lower line
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    break;
                case 6:
                    //left line
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    //upper line
                    canvas.DrawCircle(width - 10 * 3, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);

                    //middle line
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);

                    //right line
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    //lower line
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    break;
                case 7:
                    //upper line

                    canvas.DrawCircle(width - 10 * 3, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);

                    //left line
                    canvas.DrawCircle(width - 70, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);
                   
                    break;
                case 8:
                 
                    //upper line
                    canvas.DrawCircle(width - 10 * 3, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);

                    //left line
                    canvas.DrawCircle(width - 70, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);


                    // right line
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    //middle line
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 2, 10, dotsNumberPaint);

                    // lower line
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    break;
                case 9:
                    //right line 
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 5, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 6, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 7, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);

                    //middle line 
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    
                    //upper line
                    canvas.DrawCircle(width - 10 * 3, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 - 20 * 4, 10, dotsNumberPaint);


                    //left line
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 2, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 3, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 - 20 * 4, 10, dotsNumberPaint);


                    // lower line
                    canvas.DrawCircle(width - 10 * 3, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 5, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 7, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10 * 9, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    canvas.DrawCircle(width - 10, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    break;

                case -2:
                    canvas.DrawCircle(width - 25, height / 3 + 20 * 8, 10, dotsNumberPaint);
                    break;

            }
        }
   
        public MainPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1f / 60), () =>
            {
                Hour_First.InvalidateSurface();
                Hour_Second.InvalidateSurface();
                Minute_First.InvalidateSurface();
                Minute_Second.InvalidateSurface();
                Second_First.InvalidateSurface();
                Second_Second.InvalidateSurface();
                return true;
            });
        }
    }
}