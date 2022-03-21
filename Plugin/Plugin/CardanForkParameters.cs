using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    public class CardanForkParameters
    {
        /// <summary>
        /// Высота основания
        /// </summary>
        private static Parameter<int> _baseHeight;

        /// <summary>
        /// Диаметр отверстия в основании
        /// </summary>
        private static Parameter<int> _baseHoleDiameter;

        /// <summary>
        /// Ширина основания
        /// </summary>
        private static Parameter<int> _baseWidth;

        /// <summary>
        /// Длина основания
        /// </summary>
        private static Parameter<int> _baseLength;

        /// <summary>
        /// Высота детали
        /// </summary>
        private static Parameter<int> _height;

        /// <summary>
        /// Диаметр на стенке детали
        /// </summary>
        private static Parameter<int> _wallHoleDiameter;

        /// <summary>
        /// Ширина стенки детали
        /// </summary>
        private static Parameter<int> _wallThickness;
    }
}
