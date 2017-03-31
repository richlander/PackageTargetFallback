using System;
using GalaSoft.MvvmLight.Messaging;
using Cimbalino.Toolkit.Foundation;

namespace ClassLibrary1
{
    public class Class1
    {
        public static (Messenger m, Point p) Test1()
        {
            var m = new Messenger();
            var p = new Point(1, 2);
            return (m, p);
        }

    }
}
