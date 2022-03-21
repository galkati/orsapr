using System;
using NUnit.Framework;
using Plugin;

namespace PluginUnitTests
{
    [TestFixture]
    public class ParameterTests
    {
        /// <summary>
        /// ������ ���������� ������ ��� ������
        /// </summary>
        private Parameter<double> _testParameter
            = new Parameter<double>(0, 100, 0);

        [Test(Description = "���������� ���� �� ������ ����� ���������")]
        public void TestParameterNameSet()
        {
            ParameterNames newName = ParameterNames.BaseHeight;
            _testParameter.Name = newName;

            Assert.AreEqual(newName, _testParameter.Name,
                "��� ��������� ��������� �������");
        }

        [Test(Description = "���������� ���� �� ������ ����� ���������")]
        public void TestParameterNameGet()
        {
            ParameterNames newName = ParameterNames.BaseHeight;
            _testParameter.Name = newName;

            Assert.IsTrue(_testParameter.Name == newName,
                "������ ������ �������� ���");
        }

        [TestCase(-1000, Description = "�������� ������ �����������")]
        [TestCase(1000, Description = "�������� ������ �����������")]
        [Test(Description = "���������� ���� �� ������ ���������")]
        public void TestParameterSet_ValueUncorrect(double wrongValue)
        {
            Assert.Throws<Exception>(() => { _testParameter.Value = wrongValue; },
                "���������, ���� ������ ��������� ������ 100 ��� ������ 0");
        }

        [Test(Description = "���������� ���� �� ������ ���������")]
        public void TestParameterSet_Value�orrect()
        {
            var newValue = 50;
            _testParameter.Value = newValue;

            Assert.True(_testParameter.Value == newValue,
                "���������, ���� �������� �� ���� �������� � ��������");
        }

        [Test(Description = "���������� ���� �� ������ ���������")]
        public void TestParameterGet()
        {
            var testValue = 6.66;
            _testParameter.Value = testValue;

            Assert.AreEqual(_testParameter.Value, testValue,
                "���������, ���� ������ ������ �� �� ��������");
        }

        [TestCase(-1, Description = "�������� ��������� ������ ��������")]
        [Test(Description = "���������� ���� �� ������ ���������")]
        public void TestParameterMaxSet_MaxUncorrect(double wrongMax)
        {
            Assert.Throws<Exception>(() => { _testParameter.Max = wrongMax; },
                "���������, ���� ������������ �������� ������ ������������");
        }

        [Test(Description = "���������� ���� �� ������ ���������")]
        public void TestParameterMaxGet()
        {
            var parameterMax = 50;
            _testParameter.Max = parameterMax;

            Assert.AreEqual(parameterMax, _testParameter.Max,
                "������ ������ ������������ �������� ���������");
            _testParameter.Max = 100;
        }

        [Test(Description = "���������� ���� �� ������ ���������")]
        public void TestParameterMinGet()
        {
            var parameterMin = 1;
            _testParameter.Min = parameterMin;

            Assert.AreEqual(parameterMin, _testParameter.Min,
                "������ ������ ������������ �������� ��������");
            _testParameter.Min = 0;
        }
    }
}