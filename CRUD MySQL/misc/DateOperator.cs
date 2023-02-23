using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.misc
{
    public static class DateOperator
    {
        static public bool isDate(string day, string month, string year)
        {
            int dd, mm, yy;
            bool leapyear = false;
            System.DateTime moment = System.DateTime.Now;  

            try
            {

                dd = Convert.ToInt32(day);
                mm = Convert.ToInt32(month);
                yy = Convert.ToInt32(year);

                if(yy < 1941 || yy > moment.Year)
                {
                    return false;
                }


                if (yy % 4 == 0)
                {

                    if(yy % 100 == 0)
                    {

                        if(yy % 400 == 0)
                        {
                            leapyear = true;
                        }


                    }else
                    {
                        leapyear = true;
                    }

                }


                if (mm <1 || mm > 12)
                {
                    return false;
                }
                else
                {
                    switch (mm) 
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (dd < 1 || dd > 31)
                            {
                                return false;
                            }
                            break;
                        case 2:
                            if (leapyear)
                            {
                                if(dd<1 || dd > 29)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                if(dd < 1 || dd > 28)
                                {
                                    return false;
                                }
                            }
                            break;
                        default:
                            if (dd < 1 || dd > 30)
                            {
                                return false;
                            }
                            break;
                    }
                }

                return true;



            }catch(Exception e)
            {
                return false;
            }





        }



        static public DateTime? stringToDate(string stringDate, string format)
        {
            DateTime? date = new DateTime();

            try
            {
                date = DateTime.ParseExact(stringDate, format, null);
                return date;

            }catch(Exception e)
            {
                //TODO
                return null;
            }


        }


        public static string dateToString(DateTime date, string format)
        {
            string dateString;

            try
            {
                dateString = date.ToString(format);
                return dateString;

            }catch(Exception e)
            {
              
                return null;
            }

        }



        public static uint? getAge(DateTime birthDay)
        {
            DateTime currentDate = DateTime.Now;
            uint? age;
            
            try
            {
                age = Convert.ToUInt32(currentDate.Year - birthDay.Year);
                if (age < 0)
                {
                    return null;
                }
                else
                {

                    return age;

                }

            }catch(Exception e)
            {
                age = null;
                return age;
            }
            

           


        }
        

       
        static public DateTime addYears(DateTime date, int years)
        {
            DateTime output;

            try
            {
                int day = Convert.ToInt32(date.Day);
                int month = Convert.ToInt32(date.Month);
                int year = Convert.ToInt32(date.Year);

                int outputYear = year + years;

                string stringDate = day.ToString() + "/" + month.ToString() + "/" + outputYear.ToString();

                output = System.DateTime.ParseExact(stringDate, "dd/mm/yyyy", null);

                return output;
            }catch  (Exception e)
            {
                return date;
            }


        }





    }


    
}
