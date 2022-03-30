using System.Collections.Generic;
using Plugin;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class MalletParametersTests
    {
        //TODO:
        /// <summary>
        /// Свойство возвращающее новый обект класса MalletParameters
        /// </summary>
        private CardanForkParameters DefaultParameters =>
            new CardanForkParameters();

        /// <summary>
        /// Словарь имён и максимальных значений параметров
        /// </summary>
        private readonly Dictionary<ParameterNames, int>
            _maxValuesOfParameterDictionary =
                new()
                {
                    {
                        ParameterNames.BaseLength,
                        CardanForkParameters.MAX_BASE_LENGTH
                    },
                    {
                        ParameterNames.BaseHeight,
                        CardanForkParameters.MAX_BASE_HEIGHT
                    },
                    {
                        ParameterNames.BaseWidth,
                        CardanForkParameters.MAX_BASE_WIDTH
                    },
                    {
                        ParameterNames.BaseHoleDiameter,
                        CardanForkParameters.MAX_BASE_HOLE_DIAMETER
                    },
                    {
                        ParameterNames.Height,
                        CardanForkParameters.MAX_HEIGHT
                    },
                    {
                        ParameterNames.WallThickness,
                        CardanForkParameters.MAX_WALL_THICKNESS
                    },
                    {
                        ParameterNames.WallHoleDiameter,
                        CardanForkParameters.MAX_WALL_HOLE_DIAMETER
                    }
                };

        [Test(Description = "Тест метода передающий значение "
                            + "в сеттер параметра по его имени")]
        public void TestSetParameterByName()
        {
            var tsetCardanForkParameters = DefaultParameters;

            foreach (var parameterMaxValue
                     in _maxValuesOfParameterDictionary)
            {
                tsetCardanForkParameters.SetParameterByName(
                    parameterMaxValue.Key, parameterMaxValue.Value);
            }

            int errorCounter = 0;

            foreach (var parameterMaxValue
                     in _maxValuesOfParameterDictionary)
            {
                if (tsetCardanForkParameters.GetParameterValueByName(
                        parameterMaxValue.Key) != parameterMaxValue.Value)
                {
                    errorCounter++;
                }
            }

            Assert.Zero(errorCounter,
                "Значения не были помещены в сеттеры параметров");
        }

        [Test(Description = "Тест на геттер значения параметра по имени")]
        public void TestGetParameterByName()
        {
            var tsetCardanForkParameters = DefaultParameters;

            var newValue = (CardanForkParameters.MIN_HEIGHT
                            + CardanForkParameters.MIN_HEIGHT) / 2;
            ParameterNames testParameterName =
                ParameterNames.Height;
            tsetCardanForkParameters
                .SetParameterByName(testParameterName, newValue);

            Assert.AreEqual(newValue, tsetCardanForkParameters
                    .GetParameterValueByName(testParameterName),
                "Из геттера вернулось неверное значение");
        }

        [Test(Description = "Позитивный тест на геттеры параметров")]
        public void TestParameterGet()
        {
            var tsetCardanForkParameters = DefaultParameters;

            foreach (var parameterMaxValue
                     in _maxValuesOfParameterDictionary)
            {
                tsetCardanForkParameters.SetParameterByName(
                    parameterMaxValue.Key, parameterMaxValue.Value);
            }

            Assert.IsTrue(tsetCardanForkParameters.BaseHeight
                          == CardanForkParameters.MAX_BASE_HEIGHT
                          && tsetCardanForkParameters.BaseHoleDiameter
                          == CardanForkParameters.MAX_BASE_HOLE_DIAMETER
                          && tsetCardanForkParameters.Height
                          == CardanForkParameters.MAX_HEIGHT
                          && tsetCardanForkParameters.WallThickness
                          == CardanForkParameters.MAX_WALL_THICKNESS,
                "Возникает, если геттер вернул не то значение");
        }

        [Test(Description = "Тест на сеттер диаметра на стенке детали")]
        public void TestBaseWidth_Set()
        {
            var tsetCardanForkParameters = DefaultParameters;

            tsetCardanForkParameters.BaseWidth = CardanForkParameters.MAX_BASE_WIDTH;

            Assert.AreEqual(tsetCardanForkParameters.BaseLength,
                CardanForkParameters.MAX_BASE_LENGTH,
                "Сеттер не поменял знаечние зависимого параметра");
        }

        [Test(Description = "Тест на сеттер высоты основания")]
        public void TestBaseLength_Set()
        {
            var tsetCardanForkParameters = DefaultParameters;

            tsetCardanForkParameters.BaseLength = CardanForkParameters.MAX_BASE_LENGTH;

            Assert.AreEqual(tsetCardanForkParameters.BaseWidth,
                CardanForkParameters.MAX_BASE_WIDTH,
                "Сеттер не поменял знаечние зависимого параметра");
        }

        [Test(Description = "Тест на сеттер ширины основания")]
        public void TestWallHoleDiameter_Set()
        {
            var tsetCardanForkParameters = DefaultParameters;

            tsetCardanForkParameters.WallHoleDiameter = CardanForkParameters.MAX_WALL_HOLE_DIAMETER;
            tsetCardanForkParameters.BaseWidth = CardanForkParameters.MIN_BASE_WIDTH;

            Assert.AreEqual(tsetCardanForkParameters.BaseWidth - tsetCardanForkParameters.WallHoleDiameter,
                CardanForkParameters.WIDTH_DIAMETER_DIFFERENCE,
                "Сеттер не поменял знаечние зависимого параметра");
        }
    }
}