using System;
using System.Collections.Generic;

namespace CustomerSupportLogger.Models;

public partial class UserInfo
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<CustLogInfo> CustLogInfos { get; set; } = new List<CustLogInfo>();
}
