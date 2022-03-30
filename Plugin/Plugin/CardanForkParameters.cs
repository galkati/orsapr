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
        private static Parameter<int> _baseHeight = 
            new Parameter<int>(ParameterNames.BaseHeight,
                MAX_BASE_HEIGHT, MIN_BASE_HEIGHT);

        /// <summary>
        /// Диаметр отверстия в основании
        /// </summary>
        private static Parameter<int> _baseHoleDiameter = 
            new Parameter<int>(ParameterNames.BaseHoleDiameter,
                MAX_BASE_HOLE_DIAMETER, MIN_BASE_HOLE_DIAMETER);

        /// <summary>
        /// Ширина основания
        /// </summary>
        private static Parameter<int> _baseWidth =
                new Parameter<int>(ParameterNames.BaseWidth,
                    MAX_BASE_WIDTH, MIN_BASE_WIDTH);

        /// <summary>
        /// Длина основания
        /// </summary>
        private static Parameter<int> _baseLength = 
                new Parameter<int>(ParameterNames.BaseLength,
                    MAX_BASE_LENGTH, MIN_BASE_LENGTH);

        /// <summary>
        /// Высота детали
        /// </summary>
        private static Parameter<int> _height = new Parameter<int>(
            ParameterNames.Height, MAX_HEIGHT,MIN_HEIGHT);

        /// <summary>
        /// Диаметр на стенке детали
        /// </summary>
        private static Parameter<int> _wallHoleDiameter = 
                new Parameter<int>(ParameterNames.WallHoleDiameter,
                    MAX_WALL_HOLE_DIAMETER, MIN_WALL_HOLE_DIAMETER);

        /// <summary>
        /// Ширина стенки детали
        /// </summary>
        private static Parameter<int> _wallThickness =
                new Parameter<int>(ParameterNames.WallThickness,
                    MAX_WALL_THICKNESS, MIN_WALL_THICKNESS);

        /// <summary>
        /// Словарь содержащий пары (Имя параметра, указатель на него)
        /// </summary>
        private Dictionary<ParameterNames, Parameter<int>>
            _parametersDictionary =
                new Dictionary<ParameterNames, Parameter<int>>
                {
                    {_baseHeight.Name, _baseHeight},
                    {_baseHoleDiameter.Name, _baseHoleDiameter},
                    {_baseWidth.Name, _baseWidth},
                    {_baseLength.Name, _baseLength},
                    {_height.Name, _height},
                    {_wallHoleDiameter.Name, _wallHoleDiameter},
                    {_wallThickness.Name, _wallThickness}
                };

        /// <summary>
        /// Конастанты минимальных и максимальных значений параметров в мм
        /// Минимальные значения являются дефолтными
        /// </summary>
        public const int MIN_BASE_HEIGHT = 7;
        public const int MAX_BASE_HEIGHT = 14;

        public const int MIN_BASE_HOLE_DIAMETER = 2;
        public const int MAX_BASE_HOLE_DIAMETER = 5;

        public const int MIN_BASE_WIDTH = 12;
        public const int MAX_BASE_WIDTH = 22;

        public const int MIN_BASE_LENGTH = 12;
        public const int MAX_BASE_LENGTH = 22;

        public const int MIN_HEIGHT = 20;
        public const int MAX_HEIGHT = 30;

        public const int MIN_WALL_HOLE_DIAMETER = 5;
        public const int MAX_WALL_HOLE_DIAMETER = 11;

        public const int MIN_WALL_THICKNESS = 2;
        public const int MAX_WALL_THICKNESS = 5;

        /// <summary>
        /// Константы ограничений для параметров
        /// </summary>
        public const int WIDTH_DIAMETER_DIFFERENCE = 4;

        /// <summary>
        /// Конструктор класса с минимальными значенми по умолчанию
        /// </summary>
        public CardanForkParameters()
        {
            this.BaseHeight = MIN_BASE_HEIGHT;
            this.BaseHoleDiameter = MIN_BASE_HOLE_DIAMETER;
            this.BaseWidth = MIN_BASE_WIDTH;
            this.BaseLength = MIN_BASE_LENGTH;
            this.Height = MIN_HEIGHT;
            this.WallHoleDiameter = MIN_WALL_HOLE_DIAMETER;
            this.WallThickness = MIN_WALL_THICKNESS;
        }

        /// <summary>
        /// Задаёт или возвращает высоту основания
        /// </summary>
        public int BaseHeight
        {
            get => _baseHeight.Value;
            set => _baseHeight.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает диаметр отверстия в основании
        /// </summary>
        public int BaseHoleDiameter
        {
            get => _baseHoleDiameter.Value;
            set => _baseHoleDiameter.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает ширина основания
        /// </summary>
        public int BaseWidth
        {
            get => _baseWidth.Value;
            set
            {
                _baseWidth.Value = value;

                if (_baseLength.Value != value)
                {
                    BaseLength = value;
                }

                if (_wallHoleDiameter.Value > value - WIDTH_DIAMETER_DIFFERENCE)
                {
                    WallHoleDiameter = value - WIDTH_DIAMETER_DIFFERENCE;
                }
            }
        }

        /// <summary>
        /// Задаёт или возвращает высоту основания
        /// </summary>
        public int BaseLength
        {
            get => _baseLength.Value;
            set
            {
                _baseLength.Value = value;

                if (_baseWidth.Value != value)
                {
                    BaseWidth = value;
                }
            }
        }

        /// <summary>
        /// Задаёт или возвращает высоту детали
        /// </summary>
        public int Height
        {
            get => _height.Value;
            set => _height.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает диаметр на стенке детали
        /// </summary>
        public int WallHoleDiameter
        {
            get => _wallHoleDiameter.Value;
            set
            {
                _wallHoleDiameter.Value = value;

                if (value > _baseWidth.Value - WIDTH_DIAMETER_DIFFERENCE)
                {
                    BaseWidth = value + WIDTH_DIAMETER_DIFFERENCE;
                }
            }
        }

        /// <summary>
        /// Задаёт или возвращает ширина стенки детали
        /// </summary>
        public int WallThickness
        {
            get => _wallThickness.Value;
            set => _wallThickness.Value = value;
        }

        /// <summary>
        /// Метод передающй значение в сеттер параметра по имени
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        public void SetParameterByName(ParameterNames name, int value)
        {
            if (_parametersDictionary.ContainsKey(name))
            {
                switch (name)
                {
                    case ParameterNames.BaseWidth:
                        BaseWidth = value;
                        break;
                    case ParameterNames.BaseLength:
                        BaseLength = value;
                        break;
                    case ParameterNames.WallHoleDiameter:
                        WallHoleDiameter = value;
                        break;
                    default:
                        _parametersDictionary.TryGetValue(name,
                            out var parameter);
                        parameter.Value = value;
                        break;
                }
            }
        }

        /// <summary>
        /// Метод возвращающий значение параметра по имени
        /// </summary>
        /// <param name="name">Имя</param>
        /// <returns>Значение</returns>
        public int GetParameterValueByName(ParameterNames name)
        {
            _parametersDictionary.TryGetValue(name, out var parameter);
            return parameter.Value;
        }
    }
}
