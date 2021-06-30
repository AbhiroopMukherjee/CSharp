using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Practice
{
    public enum enumdemo
    {
        [Description("EmailInvitationTrigger function executed at: {DateTime.UtcNow}")]
        FunctionStarted = 100 //(100, "EmailInvitationTrigger function executed at: {DateTime.UtcNow}") = 11
    }
}
