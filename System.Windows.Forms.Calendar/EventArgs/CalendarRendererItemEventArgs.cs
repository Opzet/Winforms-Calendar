using System;
using System.Collections.Generic;
using System.Text;

namespace System.Windows.Forms.Calendar
{
    /// <summary>
    /// Contains information to render an item
    /// </summary>
    public class CalendarRendererItemEventArgs
        : CalendarRendererEventArgs
    {
        #region Fields
        private CalendarItem _item;
        #endregion

        #region Ctor


        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarRendererItemEventArgs"/> class.
        /// </summary>
        /// <param name="original">The <see cref="System.Windows.Forms.Calendar.CalendarRendererEventArgs"/> instance containing the event data.</param>
        /// <param name="item">The item.</param>
        public CalendarRendererItemEventArgs(CalendarRendererEventArgs original, CalendarItem item)
            : base(original)
        {
            _item = item;
        }

        #endregion

        #region Props

        /// <summary>
        /// Gets the Item being rendered
        /// </summary>
        public CalendarItem Item
        {
            get { return _item; }
        }


        #endregion
    }
}
