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

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    public class PSRestorableMongodbCollectionGetResult
    {
        public PSRestorableMongodbCollectionGetResult()
        {
        }

        public PSRestorableMongodbCollectionGetResult(RestorableMongodbCollectionGetResult restorableMongodbCollectionGetResult)
        {
            if (restorableMongodbCollectionGetResult == null)
            {
                return;
            }

            Id = restorableMongodbCollectionGetResult.Id;
            Name = restorableMongodbCollectionGetResult.Name;
            Type = restorableMongodbCollectionGetResult.Type;
            Resource = new PSRestorableMongodbCollectionPropertiesResource(restorableMongodbCollectionGetResult.Resource);
        }

        //
        // Summary:
        //     Gets the unique resource identifier of the RestorableMongodbCollection resource.
        public string Id { get; }

        //
        // Summary:
        //     Gets the name of the RestorableMongodbCollection resource.
        public string Name { get; }

        //
        // Summary:
        //     Gets the type of Azure resource.
        public string Type { get; }

        //
        // Summary:
        //     Gets or sets the properties of the CosmosDB Mondodb collection resource
        public PSRestorableMongodbCollectionPropertiesResource Resource { get; set; }
    }
}
