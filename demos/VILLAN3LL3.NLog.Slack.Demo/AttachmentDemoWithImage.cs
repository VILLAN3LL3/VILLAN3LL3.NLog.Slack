﻿using NLog;
using VILLAN3LL3.NLog.Slack.Models;

namespace VILLAN3LL3.NLog.Slack.Demo
{
    /// <summary>
    /// Demonstration of the implementation of ISlackLoggable
    /// </summary>
    public class AttachmentDemoWithImage : ISlackLoggable
    {
     
        public Attachment ToAttachment(LogEventInfo info)
        {
            return new Attachment
            {
                Fallback = "Network traffic (kb/s): How does this look? @slack-ops - Sent by Julie Dodd - https://www.nuget.org/packages/LibGit2Sharp-SSH",
                Title = "Network traffic (kb/s)",
                TitleLink = "https://www.nuget.org/packages/LibGit2Sharp-SSH",
                Text = "How does this look? @slack-ops - Sent by Julie Dodd",
                ImageUrl = "https://raw.githubusercontent.com/VILLAN3LL3/VILLAN3LL3.NLog.Slack/master/res/sample.png",
                Color = "#764FA5"
            };
        }
    }
}
