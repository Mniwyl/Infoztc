﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TygaSoft.IDAL;
using TygaSoft.Model;
using TygaSoft.DALFactory;

namespace TygaSoft.BLL
{
    public partial class TopicSubject
    {
        #region TopicSubject Member
        /// <summary>
        /// 添加数据到数据库
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Guid InsertByOutput(TopicSubjectInfo model)
        {
            return dal.InsertByOutput(model);
        }

        /// <summary>
        /// 置顶
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateIsTop(TopicSubjectInfo model)
        {
            return dal.UpdateIsTop(model);
        }

        /// <summary>
        /// 获取对应的数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public DataSet GetModelOW(object Id)
        {
            return dal.GetModelOW(Id);
        }

        /// <summary>
        /// 获取数据分页列表，并返回所有记录数
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRecords"></param>
        /// <param name="sqlWhere"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public DataSet GetListOW(int pageIndex, int pageSize, out int totalRecords, string sqlWhere, params SqlParameter[] cmdParms)
        {
            return dal.GetListOW(pageIndex, pageSize, out totalRecords, sqlWhere, cmdParms);
        }

        /// <summary>
        /// 获取满足当前条件的数据列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="sqlWhere"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public DataSet GetListOW(int pageIndex, int pageSize, string sqlWhere, params SqlParameter[] cmdParms)
        {
            return dal.GetListOW(pageIndex, pageSize, sqlWhere, cmdParms);
        }
        #endregion
    }
}
