<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WHouseStfManPlntHome.aspx.cs" Inherits="login.WHouseStfManPlntHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <p class="fs-1 text-center">Welcome Staff!</p>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3 ">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col" >
                                <center>
                                    <img src="imgs/drg.jpg" />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Add Drug</h3>
                                <a href="ManageDrugs.aspx">Click here to Manage Drugs</a>
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
                            <label>Drug ID</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtDrugId" runat="server" placeholder="DruglId"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVDid" runat="server" ErrorMessage="Drug Id can't be blank" ControlToValidate="txtDrugId" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            
                        </div>     
                    </div>
                         <div class="row">
                    <div class="col">
                            <label>Drug name</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtDrugName" runat="server" placeholder="DruglName"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVDname" runat="server" ErrorMessage="Drug name can't be blank" ControlToValidate="txtDrugName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            
                        </div>     
                    </div>
                    
                   <div class="row">
                        <div class="col">
                            <label>Drug Quantity</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtQty" runat="server" placeholder="Quantity"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVQty" runat="server" ErrorMessage="Quantity can't be blank" ControlToValidate="txtQty" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                    <div class="row">
                    <div class="col">
                            <label>Price per unit</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtPrice" runat="server" placeholder="price"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVprice" runat="server" ErrorMessage="Price can't be blank" ControlToValidate="txtPrice" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                          
                    <hr />
                   <div class="form-group">                        
                       <asp:Button class="btn btn-primary d-grid gap-2 col-6 mx-auto btn-lg " ID="btnAdd" runat="server" Text="Add Drug" OnClick="btnAdd_Click"   />  
                       <asp:Label ID="lbltxt" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>          
                   </div>             
            </div>
        </div>
                
                <a href="homepage.aspx">Back to Home page</a><br /><br />
    </div>
            

            <div class="col-md-4">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col" >
                                <center>
                                    <img src="imgs/order.png" />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Received Orders From SPC</h3>
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
                            <asp:GridView class="table table-hover table-bordered" ID="GridSPCOrd" runat="server"></asp:GridView> 
                        </div>     
                    </div>     
                                  
            </div>
        </div>

         </div>
               <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col" >
                                <center>
                                    <img src="imgs/order.png" />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Received Orders From Other Pharmacies</h3>
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
                            <asp:GridView class="table table-hover table-bordered" ID="GridPharOrd" runat="server"></asp:GridView> 
                        </div>     
                    </div>     
                                  
            </div>
        </div>

         </div>
         
   </div>
  </div>
</asp:Content>
