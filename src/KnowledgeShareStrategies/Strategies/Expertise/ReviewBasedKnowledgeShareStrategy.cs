﻿
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Management.Automation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace RelationalGit
{
    public class ReviewBasedKnowledgeShareStrategy : BaseKnowledgeShareStrategy
    {
        protected override DeveloperKnowledge[] SortPRKnowledgeables(PullRequestContext pullRequestContext)
        {
            return pullRequestContext.PRKnowledgeables
            .OrderBy(q => q.NumberOfReviews)
            .ThenBy(q => q.NumberOfReviewedFiles)
            .ThenBy(q=>q.NumberOfCommits).ToArray();
        }
    }
}