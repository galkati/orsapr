namespace Plugin
{
    /// <summary>
    /// Шаблонный класс параметра
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Parameter<T> where T : struct
    {
        /// <summary>
        /// Минимальное значение параметра
        /// </summary>
        private T _min;

        /// <summary>
        /// Максимальное значение параметра
        /// </summary>
        private T _max;

        /// <summary>
        /// Присваемое значение параметра
        /// </summary>
        private T _value;

        /// <summary>
        /// Название параметра для составления сообщения исключения
        /// </summary>
        private ParameterNames _name;

        /// <summary>
        /// Передаёт или задаёт имя, которое должно быть не
        /// пустым или не являтся разделяющим знаком
        /// </summary>
        public ParameterNames Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// Передаёт или задаёт минимальное значение
        /// </summary>
        public T Min
        {
            get => _min;

            set
            {
                _min = value;
            }
        }

        /// <summary>
        /// Передаёт или задаёт максимальное значение
        /// </summary>
        public T Max
        {
            get => _max;

            set
            {
                var comparerResult = Comparer<T>.Default
                    .Compare(_min, value);

                if (comparerResult >= 0)
                {
                    throw new Exception("Maximum should be "
                                        + "more or equal to minimum");
                }

                _max = value;
            }
        }

        /// <summary>
        /// Передаёт или задаёт значение параметра
        /// </summary>
        public T Value
        {
            get => _value;

            set
            {
                var comparerResultMin =
                    Comparer<T>.Default.Compare(_min, value);

                if (comparerResultMin > 0)
                {
                    throw new Exception($"{Name} should be "
                                        + $"more or equal to {Min}");
                }

                var comparerResultMax =
                    Comparer<T>.Default.Compare(value, _max);

                if (comparerResultMax > 0)
                {
                    throw new Exception($"{Name} should be "
                                        + $"less or equal to {Max}");
                }

                _value = value;
            }
        }

        /// <summary>
        /// Конструктор шаблона параметра
        /// </summary>
        /// <param name="name">Название параметра</param>
        /// <param name="max">Максимально возможное значение</param>
        /// <param name="min">Минимально возможное значение</param>
        public Parameter(ParameterNames name, T max, T min)
        {
            Name = name;
            Min = min;
            Max = max;
        }
    }
}
