<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SPC_AdminHome.aspx.cs" Inherits="login.SPC_AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="fs-1 text-center">Welcome Admin(SPC)!</p>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col" >
                                <center>
                                    <img src="imgs/tender.png" />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Advertisement For Drugs</h3>
                                <a href="AdminSearchD.aspx">Click Here to Search Drug Stock</a><br /><br />
                            </center>
                        </div>     
                    </div>

                     <div class="row">
                        <div class="col">
                            <center>
                                <hr />
                            </center>
                        </div>     
                    </div>
                       
                         <div class="row">
                    <div class="col">
                            <label>Required Drug</label>
                            <div class="form-group">
                                <asp:DropDownList  ID="DlDrgName" runat="server" Height="38px" Width="320px"></asp:DropDownList>
                            </div>
                            
                        </div>     
                    </div>
                    
                   <div class="row">
                        <div class="col">
                            <label>Required Drug Amount</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtAmount" runat="server" placeholder="amount"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVamnt" runat="server" ErrorMessage="amount can't be blank" ControlToValidate="txtAmount" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                    <div class="row">
                    <div class="col">
                            <label>Required Date</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtDate" runat="server" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVdt" runat="server" ErrorMessage="date can't be blank" ControlToValidate="txtDate" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                    <div class="row">
                    <div class="col">
                            <label>Estimated Price per unit</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtPrice" runat="server" placeholder="price"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVprice" runat="server" ErrorMessage="price can't be blank" ControlToValidate="txtPrice" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                     
                          
                    <hr />
                   <div class="form-group">                        
                       <asp:Button class="btn btn-primary d-grid gap-2 col-8 mx-auto  " ID="btnAdvertisement" runat="server" Text="Send Advertisement" OnClick="btnAdvertisement_Click"   />  
                       <asp:Label ID="lbltxt" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>          
                   </div>             
            </div>
        </div>
                
                <a href="homepage.aspx">Back to Home page</a><br /><br />
    </div>

         <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col" >
                                <center>
                                    <img src="imgs/tender.png" />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Received Tender Proposals</h3>
                                  
                            </center>
                        </div>     
                    </div>
                     <div class="row">
                        <div class="col">
                            <center>
                                <hr />
                            </center>
                        </div>     
                    </div>
                    <div class="row">
                        <div class="col">
                            <asp:GridView class="table table-hover table-bordered" ID="GridProposal" runat="server"></asp:GridView> 
                        </div>     
                    </div>     
                                
            </div>
        </div>

         </div>

            <div class="col-md-3">
                <div class="card">
                    <div class="card-body">
                             
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Use below links to registrations</h3>
                                  
                            </center>
                        </div>     
                    </div>
                     <div class="row">
                        <div class="col">
                            <center>
                                <hr />
                            </center>
                        </div>     
                    </div>
                        <div class="row">
                        <div class="col">
                            <center>
                               <a href="AddStaff.aspx">Click Here to Add/register Staff members</a><br /><br /> 
                            </center>
                        </div>     
                    </div>
                        <div class="row">
                        <div class="col">
                            <center>
                               <a href="registerPharmacies.aspx">Click Here to Add/register Pharmacies</a><br /><br /> 
                            </center>
                        </div>     
                    </div>
                    
                    </div>
                </div>
            </div>
   </div>
  </div>
</asp:Content>
