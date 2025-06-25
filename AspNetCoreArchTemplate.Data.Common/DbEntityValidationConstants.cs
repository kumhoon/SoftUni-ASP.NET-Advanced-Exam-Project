using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreArchTemplate.Data.Common
{
    public static class DbEntityValidationConstants
    {
        public static class Comment
        {
            public const int CommentContentMaxLength = 3000;
        }

        public static class Thread
        {
            public const int ThreadContentMaxLength = 4000;
        }
    }
}
