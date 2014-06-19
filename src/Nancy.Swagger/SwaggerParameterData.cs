﻿using System;
using Swagger.Model.ApiDeclaration;

namespace Nancy.Swagger
{
    public class SwaggerParameterData
    {
        public string Name { get; set; }

        public ParameterType ParamType { get; set; }

        public string Description { get; set; }

        public bool Required { get; set; }

        public bool AllowMultiple { get; set; }

        public object DefaultValue { get; set; }

        public Type ParameterModel { get; set; }
    }
}