﻿using System;

namespace Programming.Model.Geometry
{
    public class Ring
    {
        private double _innerRadius;

        private double _outerRadius;

        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }

        public Point2D Center { get; set; }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(InnerRadius), value);
                Validator.AssertValueInRange(nameof(InnerRadius), value, 0, _outerRadius);
                _innerRadius = value;
            }
        }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(OuterRadius), value);
                Validator.AssertValueInRange(nameof(OuterRadius), value, _innerRadius, double.MaxValue);
                _outerRadius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius*_outerRadius - _innerRadius*_innerRadius);
            }
        }
    }
}
