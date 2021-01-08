﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.Common.Attributes;

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    public class PSRestorableMongodbDatabaseGetResult
    {
        public PSRestorableMongodbDatabaseGetResult()
        {
        }

        public PSRestorableMongodbDatabaseGetResult(RestorableMongodbDatabaseGetResult restorableMongodbDatabaseGetResult)
        {
            if (restorableMongodbDatabaseGetResult == null)
            {
                return;
            }

            Id = restorableMongodbDatabaseGetResult.Id;
            Name = restorableMongodbDatabaseGetResult.Name;
            Type = restorableMongodbDatabaseGetResult.Type;
            Resource = new PSRestorableMongodbDatabasePropertiesResource(restorableMongodbDatabaseGetResult.Resource);
        }

        //
        // Summary:
        //     Gets the unique resource identifier of the RestorableMongodbDatabase resource.
        [Ps1Xml(Label = "Id", Target = ViewControl.List)]
        public string Id { get; }

        //
        // Summary:
        //     Gets the name of the RestorableMongodbDatabase resource.
        [Ps1Xml(Label = "Name", Target = ViewControl.List)]
        public string Name { get; }

        //
        // Summary:
        //     Gets the type of Azure resource.
        [Ps1Xml(Label = "Type", Target = ViewControl.List)]
        public string Type { get; }

        //
        // Summary:
        //     Gets or sets the properties of the CosmosDB Mondodb database resource
        [Ps1Xml(Label = "Resource", Target = ViewControl.List)]
        public PSRestorableMongodbDatabasePropertiesResource Resource { get; set; }
    }
}
