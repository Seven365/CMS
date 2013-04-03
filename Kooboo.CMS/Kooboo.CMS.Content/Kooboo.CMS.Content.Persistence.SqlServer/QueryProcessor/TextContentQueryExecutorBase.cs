﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kooboo.CMS.Content.Query;
using Kooboo.CMS.Content.Models;
using System.Data.SqlClient;

namespace Kooboo.CMS.Content.Persistence.SqlServer.QueryProcessor
{
    public abstract class TextContentQueryExecutorBase : ContentQueryExecutorBase<TextContent>
    {
        public TextContentQueryExecutorBase(ContentQuery<TextContent> contentQuery)
            : base(contentQuery)
        {           
        }
    }
}
