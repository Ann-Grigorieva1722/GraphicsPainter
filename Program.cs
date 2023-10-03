using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsPainter
{

    public enum GraphicType
    {
        Linear,
        Quadratic,
        Cubic,
        Rational,
        Logarithmic
    }
    internal static class Program
    {

        public static string GraphicTypeToString(GraphicType type)
        {
            switch (type)
            {
                case GraphicType.Linear: return "Линейная";
                case GraphicType.Quadratic: return "Квадратичная";
                case GraphicType.Cubic: return "Кубическая";
                case GraphicType.Rational: return "Рациональная";
                case GraphicType.Logarithmic: return "Логарифмическая";
                default: return "";
            }
        }


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
