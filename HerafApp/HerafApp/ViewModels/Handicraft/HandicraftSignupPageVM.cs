using HerafApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace HerafApp.ViewModels.Handicraft
{
   public  class HandicraftSignupPageVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<string> Cities
        {
            get;
            set;
        }

        public ObservableCollection<string> Months
        {
            get;
            set;
        }

        public ObservableCollection<string> Years
        {
            get;
            set;
        }

        public ObservableCollection<string> Banks
        {
            get;
            set;
        }

        public HandicraftSignupPageVM()
        {
            Cities = new ObservableCollection<string>();
            Months = new ObservableCollection<string>();
            Years = new ObservableCollection<string>();
            Banks = new ObservableCollection<string>();
            GetCities();
            GetMonths();
            GetYears();
            GetBanks();
        }

        private void GetBanks()
        {
            Banks.Clear();
            if (App.language.Equals("ar"))
            {
                Banks.Add("البنك الأهلي التجاري");
                Banks.Add("البنك السعودي البريطاني");
                Banks.Add("البنك السعودي الفرنسي");
                Banks.Add("البنك الأول");
                Banks.Add("البنك السعودي للاستثمار");
                Banks.Add("البنك العربي الوطني");
                Banks.Add("بنك البلاد");
                Banks.Add("بنك الجزيرة");
                Banks.Add("بنك الرياض");
                Banks.Add("مجموعة سامبا المالية (سامبا)");
                Banks.Add("مصرف الراجحي");
                Banks.Add("مصرف الإنماء");
                Banks.Add("بنك الخليج الدولي - السعودية");
            }
            else
            {
                Banks.Add("The National Commercial Bank");
                Banks.Add("The Saudi British Bank");
                Banks.Add("Saudi Investment Bank");
                Banks.Add("Alinma Bank");
                Banks.Add("Banque Saudi Fransi");
                Banks.Add("Riyad Bank");
                Banks.Add("Samba Financial Group (Samba)");
                Banks.Add("Alawwal Bank");
                Banks.Add("Al Rajhi Bank");
                Banks.Add("Arab National Bank");
                Banks.Add("Bank AlBilad");
                Banks.Add("Bank AlJazira");
                Banks.Add("Gulf International Bank Saudi Aribia (GIB-SA)");
            }
        }

        private void GetMonths()
        {
            Months.Clear();
            if (App.language.Equals("ar"))
            {
                Months.Add("يناير");
                Months.Add("فبراير");
                Months.Add("مارس");
                Months.Add("أبريل");
                Months.Add("مايو");
                Months.Add("يونيو");
                Months.Add("يوليو");
                Months.Add("أغسطس");
                Months.Add("سبتمبر");
                Months.Add("أكتوبر");
                Months.Add("نوفمبر");
                Months.Add("ديسمبر");
             }
            else
            {
                Months.Add("January");
                Months.Add("February");
                Months.Add("March");
                Months.Add("April");
                Months.Add("May");
                Months.Add("June");
                Months.Add("July");
                Months.Add("August");
                Months.Add("September");
                Months.Add("October");
                Months.Add("November");
                Months.Add("December");
            }

        }

        private void GetYears()
        {
            Years.Clear();
            Years.Add("2020");
            Years.Add("2021");
            Years.Add("2022");
            Years.Add("2023");
            Years.Add("2024");
            Years.Add("2025");
            Years.Add("2026");
            Years.Add("2027");
            Years.Add("2028");
            Years.Add("2029");
            Years.Add("2030");
            Years.Add("2031");
            Years.Add("2032");
            Years.Add("2033");
            Years.Add("2034");
            Years.Add("2035");
            Years.Add("2036");
            Years.Add("2037");
            Years.Add("2038");
            Years.Add("2039");
            Years.Add("2040");
            Years.Add("2041");
            Years.Add("2042");
            Years.Add("2043");
            Years.Add("2044");
            Years.Add("2045");
            Years.Add("2046");
            Years.Add("2047");
            Years.Add("2048");
            Years.Add("2049");
            Years.Add("2050");
            Years.Add("2051");
            Years.Add("2052");
            Years.Add("2053");
            Years.Add("2054");
            Years.Add("2055");
            Years.Add("2056");
            Years.Add("2057");
            Years.Add("2058");
            Years.Add("2059");
            Years.Add("2060");
        }

        private void GetCities()
        {
            Cities.Clear();
            if (App.language.Equals("ar"))
            {
                Cities.Add("أبها");
                Cities.Add("الأحساء");
                Cities.Add("الباحة");
                Cities.Add("الدمام");
                Cities.Add("الجبيل الصناعية");
                Cities.Add("الخبر");
                Cities.Add("الجوف");
                Cities.Add("الرس");
                Cities.Add("الرياض");
                Cities.Add("الطائف");
                Cities.Add("الظهران");
                Cities.Add("القطيف");
                Cities.Add("المدينة المنورة");
                Cities.Add("بريدة");
                Cities.Add("تبوك");
                Cities.Add("جدة");
                Cities.Add("جيزان");
                Cities.Add("حائل");
                Cities.Add("عنيزه");
                Cities.Add("مكة المكرمة");
                Cities.Add("نجران");
                Cities.Add("ينبع");
            }
            else
            {
                Cities.Add("Abha");
                Cities.Add("Ar-Rass");
                Cities.Add("Al-Ahsa");
                Cities.Add("Al-Khobar");
                Cities.Add("Baha");
                Cities.Add("Buraydah");
                Cities.Add("Dammam");
                Cities.Add("Dhahran");
                Cities.Add("Hail");
                Cities.Add("Jeddah");
                Cities.Add("Jizan");
                Cities.Add("Jouf");
                Cities.Add("Jubail");
                Cities.Add("Madinah");
                Cities.Add("Makkah");
                Cities.Add("Najran");
                Cities.Add("Qassem");
                Cities.Add("Qatif");
                Cities.Add("Riyadh");
                Cities.Add("Tabouk");
                Cities.Add("Taif");
                Cities.Add("Unaizah");
                Cities.Add("Yanbu");
            }
        }
    }
}
