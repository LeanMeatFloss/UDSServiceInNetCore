using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using FluentReactViewModel;
namespace StackServerProvider.Hubs
{
    public class ViewsHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            await Clients.Client(Context.ConnectionId).SendAsync("PushViewModel", new FluentReactViewModel.FluentElements.Stack());
        }
        public IEnumerable<Models.DeviceGroupDefinition> GetDeviceGroupList()
        {
            return new List<Models.DeviceGroupDefinition>(){
                    new Models.DeviceGroupDefinition(){DeviceGroupName="Vector",GroupItems=new List<string>(){"CANoe"}}
                };
        }
        public async Task ClientSendMessage(FluentReactViewModel.FluentElements.Stack res1)
        {
            await Task.Run(() =>
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
                       });

        }

    }
}