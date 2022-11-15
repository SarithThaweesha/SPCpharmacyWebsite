<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pharmacyOrdrDrg.aspx.cs" Inherits="login.pharmacyOrdrDrg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-6 m-auto">
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
                                <h3>Order Drugs</h3>
                                <a href="pharmacyHome.aspx">Back to Pharmacy Home page</a><br /><br />
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
                       
                    </div>
                        <div class="row">
                    <div class="col">
                            <label>Order ID</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtOrder" runat="server" placeholder="O_"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Order can't be blank" ControlToValidate="txtOrder" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            
                        </div>     
                    </div>
                           <div class="row">
                    <div class="col">
                            <label>Pharmacy name</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtPha" runat="server" placeholder="PharmacyName"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVpha" runat="server" ErrorMessage="Pharmacy name can't be blank" ControlToValidate="txtPha" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            
                        </div>     
                    </div>
                          <div class="row">
                    <div class="col">
                        <label>Contact no</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtCon" runat="server" placeholder="ContactNo"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVcon" runat="server" ErrorMessage="Contact number can't be blank" ControlToValidate="txtCon" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            
                        </div>     
                    </div>
                         <div class="row">
                    <div class="col">
                            <label>Drug name</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtDrugName" runat="server" placeholder="DrugName"></asp:TextBox>
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
                            <label>Date you expect the drugs</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtDate" runat="server" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVprice" runat="server" ErrorMessage="Date can't be blank" ControlToValidate="txtDate" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                          
                    <hr />
                   <div class="form-group">                        
                       <asp:Button class="btn btn-primary d-grid gap-2 col-6 mx-auto btn-lg " ID="btnOrder" runat="server" Text="Order Drug" OnClick="btnOrder_Click"     />  
                       <asp:Label ID="lbltxt" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>          
                   </div> 
                                    
            </div>
        </div>
                
                <a href="homepage.aspx">Back to Home page</a><br /><br />
                
    </div>
           

       
   </div>
  </div>
</asp:Content>
