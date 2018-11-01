using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Selector
{
    public class PersonDataTemplateSelector : DataTemplateSelector
    {
        //각각의 값은 XAML에서 작업.
        public DataTemplate ValidTemplate { get; set; }
        public DataTemplate InvalidTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject
        container)
        {
            return ((Person)item).DateOfBirth.Year >= 1980 ? ValidTemplate :
            InvalidTemplate;
        }
    }
}
