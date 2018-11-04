﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelationalGit;

namespace RelationalGit.Migrations
{
    [DbContext(typeof(GitRepositoryDbContext))]
    [Migration("20181104041749_Rename_Owner_Fields")]
    partial class Rename_Owner_Fields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RelationalGit.AliasedDeveloperName", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.HasIndex("Name");

                    b.HasIndex("NormalizedName");

                    b.ToTable("AliasedDeveloperNames");
                });

            modelBuilder.Entity("RelationalGit.Commit", b =>
                {
                    b.Property<string>("Sha")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AuthorDateTime");

                    b.Property<string>("AuthorEmail");

                    b.Property<string>("AuthorName");

                    b.Property<DateTime>("CommitterDateTime");

                    b.Property<string>("CommitterEmail");

                    b.Property<string>("CommitterName");

                    b.Property<bool>("Ignore");

                    b.Property<bool>("IsMergeCommit");

                    b.Property<string>("Message");

                    b.Property<string>("MessageShort");

                    b.Property<string>("NormalizedAuthorName");

                    b.Property<long?>("PeriodId");

                    b.Property<string>("TreeSha");

                    b.HasKey("Sha");

                    b.HasIndex("AuthorEmail");

                    b.HasIndex("AuthorName");

                    b.HasIndex("CommitterEmail");

                    b.HasIndex("Ignore");

                    b.HasIndex("NormalizedAuthorName");

                    b.HasIndex("Sha");

                    b.ToTable("Commits");
                });

            modelBuilder.Entity("RelationalGit.CommitBlobBlame", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuditedLines");

                    b.Property<double>("AuditedPercentage");

                    b.Property<string>("AuthorCommitSha");

                    b.Property<string>("CanonicalPath");

                    b.Property<string>("CommitSha");

                    b.Property<string>("DeveloperIdentity");

                    b.Property<bool>("Ignore");

                    b.Property<string>("NormalizedDeveloperIdentity");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.HasIndex("CanonicalPath");

                    b.HasIndex("CommitSha");

                    b.HasIndex("DeveloperIdentity");

                    b.HasIndex("Ignore");

                    b.HasIndex("NormalizedDeveloperIdentity");

                    b.ToTable("CommitBlobBlames");
                });

            modelBuilder.Entity("RelationalGit.CommitRelationship", b =>
                {
                    b.Property<string>("Parent");

                    b.Property<string>("Child");

                    b.HasKey("Parent", "Child");

                    b.ToTable("CommitRelationships");
                });

            modelBuilder.Entity("RelationalGit.CommittedBlob", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CanonicalPath");

                    b.Property<string>("CommitSha");

                    b.Property<int>("NumberOfLines");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.HasIndex("CanonicalPath");

                    b.HasIndex("CommitSha");

                    b.ToTable("CommittedBlob");
                });

            modelBuilder.Entity("RelationalGit.CommittedChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CanonicalPath");

                    b.Property<string>("CommitSha");

                    b.Property<string>("Extension");

                    b.Property<string>("FileType");

                    b.Property<bool>("IsTest");

                    b.Property<string>("Oid");

                    b.Property<string>("OldOid");

                    b.Property<string>("OldPath");

                    b.Property<string>("Path");

                    b.Property<short>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CanonicalPath");

                    b.HasIndex("CommitSha");

                    b.HasIndex("Oid");

                    b.HasIndex("OldOid");

                    b.HasIndex("Path");

                    b.HasIndex("Status");

                    b.ToTable("CommittedChanges");
                });

            modelBuilder.Entity("RelationalGit.Developer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllCommitPeriods");

                    b.Property<string>("AllReviewPeriods");

                    b.Property<long?>("FirstCommitPeriodId");

                    b.Property<long?>("FirstReviewPeriodId");

                    b.Property<long?>("LastCommitPeriodId");

                    b.Property<long?>("LastReviewPeriodId");

                    b.Property<string>("NormalizedName");

                    b.Property<int>("TotalCommits");

                    b.Property<int>("TotalReviews");

                    b.HasKey("Id");

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("RelationalGit.DeveloperContribution", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsCore");

                    b.Property<double>("LinesPercentage");

                    b.Property<string>("NormalizedName");

                    b.Property<long>("PeriodId");

                    b.Property<int>("TotalCommits");

                    b.Property<int>("TotalLines");

                    b.Property<int>("TotalReviews");

                    b.HasKey("Id");

                    b.ToTable("DeveloperContributions");
                });

            modelBuilder.Entity("RelationalGit.FileKnowledgeable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CanonicalPath");

                    b.Property<string>("Committers");

                    b.Property<bool>("HasReviewed");

                    b.Property<string>("Knowledgeables");

                    b.Property<long>("LossSimulationId");

                    b.Property<long>("PeriodId");

                    b.Property<string>("Reviewers");

                    b.Property<int>("TotalAvailableCommitOnly");

                    b.Property<int>("TotalAvailableCommitters");

                    b.Property<int>("TotalAvailableReviewOnly");

                    b.Property<int>("TotalAvailableReviewers");

                    b.Property<int>("TotalKnowledgeables");

                    b.HasKey("Id");

                    b.HasIndex("CanonicalPath");

                    b.HasIndex("LossSimulationId");

                    b.HasIndex("PeriodId");

                    b.HasIndex("TotalKnowledgeables");

                    b.ToTable("FileKnowledgeables");
                });

            modelBuilder.Entity("RelationalGit.FileTouch", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CanonicalPath");

                    b.Property<string>("Commits");

                    b.Property<long>("LossSimulationId");

                    b.Property<string>("NormalizeDeveloperName");

                    b.Property<long>("PeriodId");

                    b.Property<string>("PullRequests");

                    b.Property<string>("TouchType");

                    b.HasKey("Id");

                    b.HasIndex("CanonicalPath");

                    b.HasIndex("NormalizeDeveloperName");

                    b.HasIndex("PeriodId");

                    b.HasIndex("TouchType");

                    b.ToTable("FileTouches");
                });

            modelBuilder.Entity("RelationalGit.GitHubGitUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GitHubUsername");

                    b.Property<string>("GitNormalizedUsername");

                    b.Property<string>("GitUsername");

                    b.HasKey("Id");

                    b.ToTable("GitHubGitUsers");
                });

            modelBuilder.Entity("RelationalGit.Issue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<DateTime?>("ClosedAtDateTime");

                    b.Property<DateTime?>("CreatedAtDateTime");

                    b.Property<string>("HtmlUrl");

                    b.Property<string>("Label");

                    b.Property<int>("Number");

                    b.Property<string>("PullRequestNumber");

                    b.Property<string>("PullRequestUrl");

                    b.Property<string>("State");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.HasIndex("Number");

                    b.ToTable("Issue");
                });

            modelBuilder.Entity("RelationalGit.IssueComment", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreatedAtDateTime");

                    b.Property<string>("HtmltUrl");

                    b.Property<long>("IssueNumber");

                    b.Property<string>("Url");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.HasIndex("IssueNumber");

                    b.HasIndex("UserLogin");

                    b.ToTable("IssueComments");
                });

            modelBuilder.Entity("RelationalGit.IssueEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActorLogin");

                    b.Property<string>("CommitId");

                    b.Property<DateTime>("CreatedAtDateTime");

                    b.Property<string>("Event");

                    b.Property<int>("IssueNumber");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("CommitId");

                    b.HasIndex("Event");

                    b.HasIndex("IssueNumber");

                    b.ToTable("IssueEvents");
                });

            modelBuilder.Entity("RelationalGit.LossSimulation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDateTime");

                    b.Property<double>("FileAbandoningThreshold");

                    b.Property<int>("FilesAtRiksOwnersThreshold");

                    b.Property<double>("FilesAtRiksOwnershipThreshold");

                    b.Property<string>("KnowledgeShareStrategyType");

                    b.Property<int>("LeaversOfPeriodExtendedAbsence");

                    b.Property<string>("LeaversType");

                    b.Property<int>("MegaPullRequestSize");

                    b.Property<DateTime>("StartDateTime");

                    b.HasKey("Id");

                    b.ToTable("LossSimulations");
                });

            modelBuilder.Entity("RelationalGit.Period", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("FirstCommitSha");

                    b.Property<DateTime>("FromDateTime");

                    b.Property<string>("LastCommitSha");

                    b.Property<DateTime>("ToDateTime");

                    b.HasKey("Id");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("RelationalGit.PullRequest", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("BaseSha");

                    b.Property<DateTime?>("ClosedAtDateTime");

                    b.Property<DateTime?>("CreatedAtDateTime");

                    b.Property<string>("HtmlUrl");

                    b.Property<long>("IssueId");

                    b.Property<string>("IssueUrl");

                    b.Property<string>("MergeCommitSha");

                    b.Property<bool>("Merged");

                    b.Property<DateTime?>("MergedAtDateTime");

                    b.Property<int>("Number");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.HasIndex("BaseSha");

                    b.HasIndex("MergeCommitSha");

                    b.HasIndex("Number");

                    b.ToTable("PullRequests");
                });

            modelBuilder.Entity("RelationalGit.PullRequestFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Additions");

                    b.Property<int?>("Changes");

                    b.Property<int?>("Deletions");

                    b.Property<string>("FileName");

                    b.Property<int>("PullRequestNumber");

                    b.Property<string>("Sha");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("FileName");

                    b.HasIndex("PullRequestNumber");

                    b.ToTable("PullRequestFiles");
                });

            modelBuilder.Entity("RelationalGit.PullRequestReviewer", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("CommitId");

                    b.Property<long>("PullRequestNumber");

                    b.Property<string>("State");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.ToTable("PullRequestReviewers");
                });

            modelBuilder.Entity("RelationalGit.PullRequestReviewerComment", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Body");

                    b.Property<string>("CommitId");

                    b.Property<DateTime>("CreatedAtDateTime");

                    b.Property<int?>("InReplyTo");

                    b.Property<string>("Path");

                    b.Property<int>("PullRequestNumber");

                    b.Property<int?>("PullRequestReviewId");

                    b.Property<string>("PullRequestUrl");

                    b.Property<string>("Url");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.HasIndex("CommitId");

                    b.HasIndex("Path");

                    b.HasIndex("PullRequestReviewId");

                    b.HasIndex("UserLogin");

                    b.ToTable("PullRequestReviewerComments");
                });

            modelBuilder.Entity("RelationalGit.RecommendedPullRequestReviewer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("LossSimulationId");

                    b.Property<string>("NormalizedReviewerName");

                    b.Property<long>("PullRequestNumber");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedReviewerName");

                    b.HasIndex("PullRequestNumber");

                    b.ToTable("RecommendedPullRequestReviewers");
                });

            modelBuilder.Entity("RelationalGit.SimulatedAbondonedFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AbandonedLinesInPeriod");

                    b.Property<string>("FilePath");

                    b.Property<long>("LossSimulationId");

                    b.Property<long>("PeriodId");

                    b.Property<string>("RiskType");

                    b.Property<int>("SavedLinesInPeriod");

                    b.Property<int>("TotalLinesInPeriod");

                    b.HasKey("Id");

                    b.ToTable("SimulatedAbondonedFiles");
                });

            modelBuilder.Entity("RelationalGit.SimulatedLeaver", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LeavingType");

                    b.Property<long>("LossSimulationId");

                    b.Property<string>("NormalizedName");

                    b.Property<long>("PeriodId");

                    b.HasKey("Id");

                    b.ToTable("SimulatedLeavers");
                });

            modelBuilder.Entity("RelationalGit.User", b =>
                {
                    b.Property<string>("UserLogin")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("UserLogin");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
