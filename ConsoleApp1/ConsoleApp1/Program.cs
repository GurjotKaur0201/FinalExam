using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // calendarvisibilityEventArgs obj = new calendarvisibilityEventArgs(false);
            
        }
        public event CalendarVisibilityEventHandler calevent;
        protected virtual void Onchange()
        {
            if(calevent != null)
            {
                calendarvisibilityEventArgs obj = new calendarvisibilityEventArgs(false);
                calevent(this,obj);
            }
        }
        

    }

    public class calendarvisibilityEventArgs: EventArgs
    {
        private bool _isCalendarVisible;
        public bool IsCalendarVisible
        {
            get
            {
                return this._isCalendarVisible;
            }
        }
        public calendarvisibilityEventArgs(bool isCalendarVisible)
        {
            this._isCalendarVisible = isCalendarVisible;
        }
    }
    public delegate void CalendarVisibilityEventHandler(object sender, calendarvisibilityEventArgs e);
}
