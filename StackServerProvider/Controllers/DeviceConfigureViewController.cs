using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FluentReactViewModel;
namespace StackServerProvider.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceConfigureViewController
    {
        private readonly ILogger<Models.DeviceItem> _logger;

        public DeviceConfigureViewController(ILogger<Models.DeviceItem> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public FluentReactViewModel.FluentElements.Stack Get()
        {
            Dictionary<string, string> longjsonCss = new Dictionary<string, string>()
            {
                {"max-width","50%"}
            };
            FluentReactViewModel.FluentElements.Stack stack = new FluentReactViewModel.FluentElements.Stack()
            {
                Tokens = new FluentReactViewModel.FluentElements.Stack.IStackTokens()
                {
                    //Horizontal = true,
                    ChildrenGap = 10,
                },
                Horizontal = true,
                Wrap = true,

            };
            stack.ChildrenList = new object[]
            {
                new FluentReactViewModel.FluentElements.StackItem()
                {
                    ChildrenList=new object[]{
                        new FluentReactViewModel.FluentElements.ComboBox()
                            {
                                Options = new FluentReactViewModel.FluentElements.ComboBox.IComboBoxOption[]
                                {
                                    new FluentReactViewModel.FluentElements.ComboBox.IComboBoxOption(){
                                        Key="21",
                                        Text="test01",
                                    }
                                }

                            },
                    },
                    Grow=2,
                },
                new FluentReactViewModel.FluentElements.StackItem()
                {
                    ChildrenList=new object[]{
                        new FluentReactViewModel.FluentElements.ComboBox()
                            {
                                Options = new FluentReactViewModel.FluentElements.ComboBox.IComboBoxOption[]
                                {
                                    new FluentReactViewModel.FluentElements.ComboBox.IComboBoxOption(){
                                        Key="1",
                                        Text="test01",
                                    }
                                },
                                Label="Select Device1"

                            },
                    },
                    Grow=1,
                },
                new FluentReactViewModel.FluentElements.StackItem()
                {
                    ChildrenList=new object[]{
                        new FluentReactViewModel.FluentElements.ComboBox()
                            {
                                Options = new FluentReactViewModel.FluentElements.ComboBox.IComboBoxOption[]
                                {
                                    new FluentReactViewModel.FluentElements.ComboBox.IComboBoxOption(){
                                        Key="1",
                                        Text="test01",
                                    }
                                }

                            },
                    },
                    Grow=10,
                },

            };

            return stack;
        }
    }
}