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
        private static Parameter<double> _baseHeight = 
            new Parameter<double>(ParameterNames.BaseHeight,
                MAX_BASE_HEIGHT, MIN_BASE_HEIGHT);

        /// <summary>
        /// Диаметр отверстия в основании
        /// </summary>
        private static Parameter<double> _baseHoleDiameter = 
            new Parameter<double>(ParameterNames.BaseHoleDiameter,
                MAX_BASE_HOLE_DIAMETER, MIN_BASE_HOLE_DIAMETER);

        /// <summary>
        /// Ширина основания
        /// </summary>
        private static Parameter<double> _baseWidth =
                new Parameter<double>(ParameterNames.BaseWidth,
                    MAX_BASE_WIDTH, MIN_BASE_WIDTH);

        /// <summary>
        /// Длина основания
        /// </summary>
        private static Parameter<double> _baseLength = 
                new Parameter<double>(ParameterNames.BaseLength,
                    MAX_BASE_LENGTH, MIN_BASE_LENGTH);

        /// <summary>
        /// Высота детали
        /// </summary>
        private static Parameter<double> _height = new Parameter<double>(
            ParameterNames.Height, MAX_HEIGHT,MIN_HEIGHT);

        /// <summary>
        /// Диаметр на стенке детали
        /// </summary>
        private static Parameter<double> _wallHoleDiameter = 
                new Parameter<double>(ParameterNames.WallHoleDiameter,
                    MAX_WALL_HOLE_DIAMETER, MIN_WALL_HOLE_DIAMETER);

        /// <summary>
        /// Ширина стенки детали
        /// </summary>
        private static Parameter<double> _wallThickness =
                new Parameter<double>(ParameterNames.WallThickness,
                    MAX_WALL_THICKNESS, MIN_WALL_THICKNESS);

        /// <summary>
        /// Словарь содержащий пары (Имя параметра, указатель на него)
        /// </summary>
        private Dictionary<ParameterNames, Parameter<double>>
            _parametersDictionary = new()
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
        public const double MIN_BASE_HEIGHT = 7;
        public const double MAX_BASE_HEIGHT = 13;

        public const double MIN_BASE_HOLE_DIAMETER = 1;
        public const double MAX_BASE_HOLE_DIAMETER = 5;

        public const double MIN_BASE_WIDTH = 12;
        public const double MAX_BASE_WIDTH = 22;

        public const double MIN_BASE_LENGTH = 12;
        public const double MAX_BASE_LENGTH = 22;

        public const double MIN_HEIGHT = 20;
        public const double MAX_HEIGHT = 30;

        public const double MIN_WALL_HOLE_DIAMETER = 5;
        public const double MAX_WALL_HOLE_DIAMETER = 11;

        public const double MIN_WALL_THICKNESS = 2;
        public const double MAX_WALL_THICKNESS = 5;

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
        public double BaseHeight
        {
            get => _baseHeight.Value;
            set => _baseHeight.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает диаметр отверстия в основании
        /// </summary>
        public double BaseHoleDiameter
        {
            get => _baseHoleDiameter.Value;
            set => _baseHoleDiameter.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает ширина основания
        /// </summary>
        public double BaseWidth
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
        public double BaseLength
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
        public double Height
        {
            get => _height.Value;
            set => _height.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает диаметр на стенке детали
        /// </summary>
        public double WallHoleDiameter
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
        public double WallThickness
        {
            get => _wallThickness.Value;
            set => _wallThickness.Value = value;
        }

        /// <summary>
        /// Метод передающй значение в сеттер параметра по имени
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        public void SetParameterByName(ParameterNames name, double value)
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
        public double GetParameterValueByName(ParameterNames name)
        {
            _parametersDictionary.TryGetValue(name, out var parameter);
            return parameter.Value;
        }
    }
}
