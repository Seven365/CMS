﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Kooboo.Web.Mvc.Grid
{
    public interface IColumnHeaderRender
    {
        IHtmlString Render(object value, ViewContext viewContext);
    }
}
