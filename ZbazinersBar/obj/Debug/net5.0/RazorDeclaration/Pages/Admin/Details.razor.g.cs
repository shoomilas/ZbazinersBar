// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ZbazinersBar.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\_Scratchpad\Zbaziners\ZbazinersBar\ZbazinersBar\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_Scratchpad\Zbaziners\ZbazinersBar\ZbazinersBar\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\_Scratchpad\Zbaziners\ZbazinersBar\ZbazinersBar\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\_Scratchpad\Zbaziners\ZbazinersBar\ZbazinersBar\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\_Scratchpad\Zbaziners\ZbazinersBar\ZbazinersBar\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\_Scratchpad\Zbaziners\ZbazinersBar\ZbazinersBar\Pages\Admin\_Imports.razor"
using ZbazinersBar.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/Items/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\_Scratchpad\Zbaziners\ZbazinersBar\ZbazinersBar\Pages\Admin\Details.razor"
       

    [Inject]
    public IStoreRepository Repository { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Item Item { get; set; }

    protected override void OnParametersSet() {
        Item = Repository.Items.FirstOrDefault(p => p.ItemID == Id);
    }

    public string EditUrl => $"/admin/Items/edit/{Item.ItemID}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
