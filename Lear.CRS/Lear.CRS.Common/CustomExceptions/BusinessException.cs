﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lear.CRS.Common.CustomExceptions
{
    /// <summary>
    /// 业务异常类
    /// 业务中可预见得异常
    /// </summary>
    public class BusinessException : Exception
    {
        public BusinessException() { }
        public BusinessException(string message) : base(message) { }
        public BusinessException(string message, Exception innerException) : base(message, innerException) { }
    }
}
