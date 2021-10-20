using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagram
{
    public class Клиент
    {
        private int НомерКарточки;
        private string ФИО;
        private String Адрес;
        private int Телефон;

        public Заказы Заказы
        {
            get => default;
            set
            {
            }
        }

        public void ДобавитьКлиента()
        {
            throw new System.NotImplementedException();
        }

        public void УдалитьКлиента()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Сотрудники
    {
        private int Фамилия;
        private int Имя;
        private int СтажРаботы;
        private decimal Зарплата;

        public Автомобиль Автомобиль
        {
            get => default;
            set
            {
            }
        }

        public void ДобавитьВодителя()
        {
            throw new System.NotImplementedException();
        }

        public void УдалитьВодителя()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Автомобиль
    {
        private int НомерАвто;
        private string Марка;
        private int ГосНомер;
        private int Водитель;

        public Заказы Заказы
        {
            get => default;
            set
            {
            }
        }

        public void ДобавитьАвто()
        {
            throw new System.NotImplementedException();
        }

        public void Удалить()
        {
            throw new System.NotImplementedException();
        }

        public void ДобавитьВодителя()
        {
            throw new System.NotImplementedException();
        }

        public void ОтстранитьВодителя()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Заказы
    {
        private int НомерЗаказа;
        private date ДатаЗаказа;
        private int ВремяЗаказа;
        private int НомерАвто;
        private int НомерКарточки;
        private decimal СуммаЗаказа;
        private string СостояниеЗаказа;

        public void СоздатьЗаказ()
        {
            throw new System.NotImplementedException();
        }

        public void УдалитьЗаказ()
        {
            throw new System.NotImplementedException();
        }

        public void ИзменитьЗаказ()
        {
            throw new System.NotImplementedException();
        }
    }
}