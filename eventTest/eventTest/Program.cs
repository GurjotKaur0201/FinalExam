using System;

namespace eventTest
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
        public event CalendarvisibilityEventHandler cal;
        protected void calendar(object sender, CalendarvisiblitityEventArgs e)
        {
            if (cal != null)
            {

            }
        }
    }
    
    public class CalendarvisiblitityEventArgs: EventArgs
	{
		private bool _isCalendarVisible;

		public bool IsCalendarVisible
        {
            get
            {
				return this._isCalendarVisible;
            }
        }
        public CalendarvisiblitityEventArgs(bool isCalendarVisible)
        {
            this._isCalendarVisible = isCalendarVisible;
        }

	}
    public delegate void CalendarvisibilityEventHandler(object sender, CalendarvisiblitityEventArgs e);


	
}
