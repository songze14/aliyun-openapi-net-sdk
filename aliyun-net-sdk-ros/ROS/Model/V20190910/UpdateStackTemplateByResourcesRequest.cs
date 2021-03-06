/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20190910;

namespace Aliyun.Acs.ROS.Model.V20190910
{
    public class UpdateStackTemplateByResourcesRequest : RpcAcsRequest<UpdateStackTemplateByResourcesResponse>
    {
        public UpdateStackTemplateByResourcesRequest()
            : base("ROS", "2019-09-10", "UpdateStackTemplateByResources", "ros", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string stackId;

		private List<string> logicalResourceIds = new List<string>(){ };

		private bool? dryRun;

		private string templateFormat;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string StackId
		{
			get
			{
				return stackId;
			}
			set	
			{
				stackId = value;
				DictionaryUtil.Add(QueryParameters, "StackId", value);
			}
		}

		public List<string> LogicalResourceIds
		{
			get
			{
				return logicalResourceIds;
			}

			set
			{
				logicalResourceIds = value;
				for (int i = 0; i < logicalResourceIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LogicalResourceId." + (i + 1) , logicalResourceIds[i]);
				}
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public string TemplateFormat
		{
			get
			{
				return templateFormat;
			}
			set	
			{
				templateFormat = value;
				DictionaryUtil.Add(QueryParameters, "TemplateFormat", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateStackTemplateByResourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateStackTemplateByResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
