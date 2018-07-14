﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class CustomerTypeRepository
    {
        public List<CustomerType> Retrive()
        {
            List<CustomerType> customerTypeList = new List<CustomerType>()
            {
                new CustomerType()
                {
                    CustomerTypeId=1,
                    TypeName="Corporate",
                    DisplayOrder = 2},
                new CustomerType()
                {
                    CustomerTypeId=2,
                    TypeName="individual",
                    DisplayOrder = 1},
                new CustomerType()
                {
                    CustomerTypeId=3,
                    TypeName="Eduator",
                    DisplayOrder = 4},
                new CustomerType()
                {
                    CustomerTypeId=4,
                    TypeName="Government",
                    DisplayOrder = 3}
                };
            return customerTypeList;
        }
    }
}
