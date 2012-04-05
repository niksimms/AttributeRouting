﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeRouting.Framework {
    public interface IAttributeRouteFactory<TConstraint, TController, TRoute, TRouteParameter> {

        /// <summary>
        /// Create a new attribute route that wraps an underlying framework route
        /// </summary>
        /// <param name="url"></param>
        /// <param name="defaults"></param>
        /// <param name="constraints"></param>
        /// <param name="dataTokens"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        AttributeRouteBase<TRoute> CreateAttributeRoute(string url,
            IDictionary<string, object> defaults,
            IDictionary<string, object> constraints,
            IDictionary<string, object> dataTokens,
            AttributeRoutingConfiguration<TConstraint, TController, TRoute, TRouteParameter> configuration);
    }
}
