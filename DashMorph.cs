using System;
using System.Threading;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace DashMorph
{
    class DashMorph : NUIApplication
    {
        public DashMorph() : base()
        {
            Console.WriteLine("new DashMorph");
        }

        protected override void OnCreate()
        {
            base.OnCreate();
            Initialize();
        }

        private void Initialize()
        {
            Console.WriteLine("Initialize");
            Window window = Window.Instance;
            window.BackgroundColor = Color.White;

            ImageView imageView1 = new ImageView("./res/images/little-dog.jpg");
            ImageView imageView2 = new ImageView("./res/images/little-dog.jpg");
            ImageView imageView3 = new ImageView("./res/images/little-dog.jpg");

            imageView2.Position2D = new Position2D( 160, 0 );
            imageView3.Position2D = new Position2D( 320, 0 );

            window.Add(imageView1);
            window.Add(imageView2);
            window.Add(imageView3);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var interval = new TimeSpan(0, 0, 10 );
            Thread.Sleep(interval);
            DashMorph dashMorph = new DashMorph();
            dashMorph.Run(args);
        }
    }
}
