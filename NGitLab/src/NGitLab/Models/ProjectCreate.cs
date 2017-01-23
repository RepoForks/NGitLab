﻿using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class ProjectCreate
    {
        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "namespace_id")]
        public string NamespaceId;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "path")]
        public string Path;

        [DataMember(Name = "issues_enabled")]
        public bool IssuesEnabled;

        [DataMember(Name = "wall_enabled")]
        public bool WallEnabled;

        [DataMember(Name = "merge_requests_enabled")]
        public bool MergeRequestsEnabled;

        [DataMember(Name = "snippets_enabled")]
        public bool SnippetsEnabled;

        [DataMember(Name = "wiki_enabled")]
        public bool WikiEnabled;

        [DataMember(Name = "import_url")]
        public string ImportUrl;

        [DataMember(Name = "visibility_level")]
        public VisibilityLevel VisibilityLevel;
    }
}