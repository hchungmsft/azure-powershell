// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Management.Compute.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("New", "AzureRmContainerServiceConfig")]
    [OutputType(typeof(ContainerService))]
    public class NewAzureRmContainerServiceConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public ContainerServiceOchestratorTypes? OrchestratorType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public int? MasterCount { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string MasterDnsPrefix { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        public ContainerServiceAgentPoolProfile[] AgentPoolProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public string WindowsProfileAdminUsername { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public string WindowsProfileAdminPassword { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public string AdminUsername { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true)]
        public string[] SshPublicKey { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true)]
        public bool? VmDiagnosticsEnabled { get; set; }

        protected override void ProcessRecord()
        {
            // OrchestratorProfile
            Microsoft.Azure.Management.Compute.Models.ContainerServiceOrchestratorProfile vOrchestratorProfile = null;

            // MasterProfile
            Microsoft.Azure.Management.Compute.Models.ContainerServiceMasterProfile vMasterProfile = null;

            // WindowsProfile
            Microsoft.Azure.Management.Compute.Models.ContainerServiceWindowsProfile vWindowsProfile = null;

            // LinuxProfile
            Microsoft.Azure.Management.Compute.Models.ContainerServiceLinuxProfile vLinuxProfile = null;

            // DiagnosticsProfile
            Microsoft.Azure.Management.Compute.Models.ContainerServiceDiagnosticsProfile vDiagnosticsProfile = null;

            if (this.OrchestratorType != null)
            {
                if (vOrchestratorProfile == null)
                {
                    vOrchestratorProfile = new Microsoft.Azure.Management.Compute.Models.ContainerServiceOrchestratorProfile();
                }
                vOrchestratorProfile.OrchestratorType = this.OrchestratorType;
            }

            if (this.MasterCount != null)
            {
                if (vMasterProfile == null)
                {
                    vMasterProfile = new Microsoft.Azure.Management.Compute.Models.ContainerServiceMasterProfile();
                }
                vMasterProfile.Count = this.MasterCount;
            }

            if (this.MasterDnsPrefix != null)
            {
                if (vMasterProfile == null)
                {
                    vMasterProfile = new Microsoft.Azure.Management.Compute.Models.ContainerServiceMasterProfile();
                }
                vMasterProfile.DnsPrefix = this.MasterDnsPrefix;
            }

            if (this.WindowsProfileAdminUsername != null)
            {
                if (vWindowsProfile == null)
                {
                    vWindowsProfile = new Microsoft.Azure.Management.Compute.Models.ContainerServiceWindowsProfile();
                }
                vWindowsProfile.AdminUsername = this.WindowsProfileAdminUsername;
            }

            if (this.WindowsProfileAdminPassword != null)
            {
                if (vWindowsProfile == null)
                {
                    vWindowsProfile = new Microsoft.Azure.Management.Compute.Models.ContainerServiceWindowsProfile();
                }
                vWindowsProfile.AdminPassword = this.WindowsProfileAdminPassword;
            }

            if (this.AdminUsername != null)
            {
                if (vLinuxProfile == null)
                {
                    vLinuxProfile = new Microsoft.Azure.Management.Compute.Models.ContainerServiceLinuxProfile();
                }
                vLinuxProfile.AdminUsername = this.AdminUsername;
            }


            if (this.SshPublicKey != null)
            {
                if (vLinuxProfile == null)
                {
                    vLinuxProfile = new Microsoft.Azure.Management.Compute.Models.ContainerServiceLinuxProfile();
                }
                if (vLinuxProfile.Ssh == null)
                {
                    vLinuxProfile.Ssh = new Microsoft.Azure.Management.Compute.Models.ContainerServiceSshConfiguration();
                }
                if (vLinuxProfile.Ssh.PublicKeys == null)
                {
                    vLinuxProfile.Ssh.PublicKeys = new List<Microsoft.Azure.Management.Compute.Models.ContainerServiceSshPublicKey>();
                }
                foreach (var element in this.SshPublicKey)
                {
                    var vPublicKeys = new Microsoft.Azure.Management.Compute.Models.ContainerServiceSshPublicKey();
                    vPublicKeys.KeyData = element;
                    vLinuxProfile.Ssh.PublicKeys.Add(vPublicKeys);
                }
            }

            if (this.VmDiagnosticsEnabled != null)
            {
                if (vDiagnosticsProfile == null)
                {
                    vDiagnosticsProfile = new Microsoft.Azure.Management.Compute.Models.ContainerServiceDiagnosticsProfile();
                }
                if (vDiagnosticsProfile.VmDiagnostics == null)
                {
                    vDiagnosticsProfile.VmDiagnostics = new Microsoft.Azure.Management.Compute.Models.ContainerServiceVMDiagnostics();
                }
                vDiagnosticsProfile.VmDiagnostics.Enabled = this.VmDiagnosticsEnabled;
            }


            var vContainerService = new ContainerService
            {
                Location = this.Location,
                Tags = (this.Tag == null) ? null : this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value),
                AgentPoolProfiles = this.AgentPoolProfile,
                OrchestratorProfile = vOrchestratorProfile,
                MasterProfile = vMasterProfile,
                WindowsProfile = vWindowsProfile,
                LinuxProfile = vLinuxProfile,
                DiagnosticsProfile = vDiagnosticsProfile,
            };

            WriteObject(vContainerService);
        }
    }
}

