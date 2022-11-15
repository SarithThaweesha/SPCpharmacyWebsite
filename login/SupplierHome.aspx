<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SupplierHome.aspx.cs" Inherits="login.SupplierHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="fs-1 text-center">Welcome Supplier!</p>
<div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
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
                                <h3>Tender Proposal</h3>
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
                            <label>Proposal ID</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtPropId" runat="server" placeholder="ProposalId"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Proposal Id can't be blank" ControlToValidate="txtPropId" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            
                        </div>     
                    </div>
                         <div class="row">
                    <div class="col">
                            <label>Supplier ID</label>
                            <div class="form-group">
                                <asp:DropDownList  ID="DlSup" runat="server" Height="44px" Width="576px"></asp:DropDownList>
                            </div>
                            
                        </div>     
                    </div>
                    <div class="row">
                    <div class="col">
                            <label>Drug Name</label>
                            <div class="form-group">
                                <asp:DropDownList  ID="Dldrug" runat="server" Height="44px" Width="576px"></asp:DropDownList>
                            </div>
                            
                        </div>     
                    </div>
                   <div class="row">
                        <div class="col">
                            <label>Possible Supply Date</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtDate" runat="server" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVaddr" runat="server" ErrorMessage="Date can't be blank" ControlToValidate="txtDate" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                    <div class="row">
                    <div class="col">
                            <label>Contact number</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtContact" runat="server" placeholder="Contact"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVcont" runat="server" ErrorMessage="Contact can't be blank" ControlToValidate="txtContact" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                    <div class="row">
                    <div class="col">
                            <label>Email</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtEmail" runat="server" placeholder="email"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVemail" runat="server" ErrorMessage="Email can't be blank" ControlToValidate="txtEmail" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                     <div class="row">
                    <div class="col">
                            <label>Price per unit</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtPrice" runat="server" placeholder="price"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVUName" runat="server" ErrorMessage="Price can't be blank" ControlToValidate="txtPrice" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                          
                    <hr />
                   <div class="form-group">                        
                       <asp:Button class="btn btn-primary d-grid gap-2 col-6 mx-auto btn-lg " ID="btnSubmit" runat="server" Text="Submit Proposal" OnClick="btnSubmit_Click"  />  
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
                                    <img src="imgs/tender.png" />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Available Tenders</h3>
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
                            <asp:GridView class="table table-hover table-bordered" ID="GridView1" runat="server"></asp:GridView> 
                        </div>     
                    </div>     
                                  
            </div>
        </div>

         </div>
            <div class="col-md-3">
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
                                <h3>Drug List</h3>
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
                            <asp:GridView class="table table-hover table-bordered" ID="GridView2" runat="server"></asp:GridView> 
                        </div>     
                    </div>     
                                  
            </div>
        </div>

         </div>
   </div>
  </div>
</asp:Content>
