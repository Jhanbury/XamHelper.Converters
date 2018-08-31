﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using XamHelper.Guards;

namespace XamHelper.Converters
{
    public class CollectionToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Guard.ThrowIfNull(value, "Collection");
            try
            {
                ICollection collection = value as ICollection;
                return collection.Count;
            }
            catch (Exception)
            {
                return 0;
            }
            

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
