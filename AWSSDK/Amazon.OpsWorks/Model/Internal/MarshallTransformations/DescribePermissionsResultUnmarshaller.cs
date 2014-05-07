/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DescribePermissionsResultUnmarshaller
      /// </summary>
      internal class DescribePermissionsResultUnmarshaller : IUnmarshaller<DescribePermissionsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribePermissionsResult, JsonUnmarshallerContext>
      {
        DescribePermissionsResult IUnmarshaller<DescribePermissionsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribePermissionsResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            DescribePermissionsResult describePermissionsResult = new DescribePermissionsResult();
          describePermissionsResult.Permissions = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Permissions", targetDepth))
              {
                describePermissionsResult.Permissions = new List<Permission>();   
                if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                {
                  continue;
                }              

                  PermissionUnmarshaller unmarshaller = PermissionUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describePermissionsResult.Permissions.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return describePermissionsResult;
                }
            }
          

            return describePermissionsResult;
        }

        private static DescribePermissionsResultUnmarshaller instance;
        public static DescribePermissionsResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribePermissionsResultUnmarshaller();
            return instance;
        }
    }
}
  