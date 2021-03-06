﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TygaSoft.Model;

namespace TygaSoft.IDAL
{
    public partial interface IUserLevelView
    {
        #region IUserLevelView Member

        bool IsExist(object userId, int funCode, int enumSource);

        UserLevelViewInfo GetModel(object userId, int funCode, int enumSource);

        #endregion
    }
}
