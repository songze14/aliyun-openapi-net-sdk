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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeMPULayoutInfoListResponseUnmarshaller
    {
        public static DescribeMPULayoutInfoListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMPULayoutInfoListResponse describeMPULayoutInfoListResponse = new DescribeMPULayoutInfoListResponse();

			describeMPULayoutInfoListResponse.HttpResponse = context.HttpResponse;
			describeMPULayoutInfoListResponse.RequestId = context.StringValue("DescribeMPULayoutInfoList.RequestId");
			describeMPULayoutInfoListResponse.TotalNum = context.LongValue("DescribeMPULayoutInfoList.TotalNum");
			describeMPULayoutInfoListResponse.TotalPage = context.LongValue("DescribeMPULayoutInfoList.TotalPage");

			List<DescribeMPULayoutInfoListResponse.DescribeMPULayoutInfoList_Layout> describeMPULayoutInfoListResponse_layouts = new List<DescribeMPULayoutInfoListResponse.DescribeMPULayoutInfoList_Layout>();
			for (int i = 0; i < context.Length("DescribeMPULayoutInfoList.Layouts.Length"); i++) {
				DescribeMPULayoutInfoListResponse.DescribeMPULayoutInfoList_Layout layout = new DescribeMPULayoutInfoListResponse.DescribeMPULayoutInfoList_Layout();
				layout.LayoutId = context.LongValue("DescribeMPULayoutInfoList.Layouts["+ i +"].LayoutId");
				layout.Name = context.StringValue("DescribeMPULayoutInfoList.Layouts["+ i +"].Name");
				layout.AudioMixCount = context.IntegerValue("DescribeMPULayoutInfoList.Layouts["+ i +"].AudioMixCount");

				List<DescribeMPULayoutInfoListResponse.DescribeMPULayoutInfoList_Layout.DescribeMPULayoutInfoList_PanesItem> layout_panes = new List<DescribeMPULayoutInfoListResponse.DescribeMPULayoutInfoList_Layout.DescribeMPULayoutInfoList_PanesItem>();
				for (int j = 0; j < context.Length("DescribeMPULayoutInfoList.Layouts["+ i +"].Panes.Length"); j++) {
					DescribeMPULayoutInfoListResponse.DescribeMPULayoutInfoList_Layout.DescribeMPULayoutInfoList_PanesItem panesItem = new DescribeMPULayoutInfoListResponse.DescribeMPULayoutInfoList_Layout.DescribeMPULayoutInfoList_PanesItem();
					panesItem.PaneId = context.IntegerValue("DescribeMPULayoutInfoList.Layouts["+ i +"].Panes["+ j +"].PaneId");
					panesItem.MajorPane = context.IntegerValue("DescribeMPULayoutInfoList.Layouts["+ i +"].Panes["+ j +"].MajorPane");
					panesItem.X = context.FloatValue("DescribeMPULayoutInfoList.Layouts["+ i +"].Panes["+ j +"].X");
					panesItem.Y = context.FloatValue("DescribeMPULayoutInfoList.Layouts["+ i +"].Panes["+ j +"].Y");
					panesItem.Width = context.FloatValue("DescribeMPULayoutInfoList.Layouts["+ i +"].Panes["+ j +"].Width");
					panesItem.Height = context.FloatValue("DescribeMPULayoutInfoList.Layouts["+ i +"].Panes["+ j +"].Height");
					panesItem.ZOrder = context.IntegerValue("DescribeMPULayoutInfoList.Layouts["+ i +"].Panes["+ j +"].ZOrder");

					layout_panes.Add(panesItem);
				}
				layout.Panes = layout_panes;

				describeMPULayoutInfoListResponse_layouts.Add(layout);
			}
			describeMPULayoutInfoListResponse.Layouts = describeMPULayoutInfoListResponse_layouts;
        
			return describeMPULayoutInfoListResponse;
        }
    }
}
