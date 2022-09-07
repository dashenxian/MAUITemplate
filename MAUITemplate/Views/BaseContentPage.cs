using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITemplate.Views
{
    public partial class BaseContentPage : ContentPage
    {
        public BaseContentPage(BaseViewModel viewModel)
        {
            BindingContext = viewModel;
        }
    }
}
