<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="supplierRegister.aspx.cs" Inherits="login.supplierRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <div class="container">
        <div class="row">
            <div class="col-md-6 m-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col" >
                                <center>
                                    <img src="imgs/adm.png" />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Supplier Registration</h3>
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
                            <label>Supplier ID</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtSupId" runat="server" placeholder="SupplierID"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVsupId" runat="server" ErrorMessage="Supplier Id can't be blank" ControlToValidate="txtSupId" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            
                        </div>     
                    </div>
                    <div class="row">
                    <div class="col">
                            <label>Supplier Name</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtSupName" runat="server" placeholder="SupplierName"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVsname" runat="server" ErrorMessage="Supplier Name can't be blank" ControlToValidate="txtSupName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            
                        </div>     
                    </div>
                   <div class="row">
                        <div class="col">
                            <label>Address</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtAddress" runat="server" placeholder="Address"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVaddr" runat="server" ErrorMessage="Address can't be blank" ControlToValidate="txtAddress" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
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
                            <label>Username</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtUsername" runat="server" placeholder="username"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVUName" runat="server" ErrorMessage="userName can't be blank" ControlToValidate="txtUsername" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>              
                        </div>     
                    </div>
                         <div class="row">
                        <div class="col">
                            <label>Password</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtPw" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVpw" runat="server" ErrorMessage="password can't be blank" ControlToValidate="txtPw" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>   
                        </div>     
                    </div>
                         <div class="row">
                        <div class="col">
                            <label>Confirm Password</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtConPw" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFVConPW" runat="server" ErrorMessage="field can't be blank" ControlToValidate="txtConPw" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="cvConfirmPassword" runat="server" ErrorMessage="Password and confirm password should match" 
                     ControlToCompare="txtPw" ControlToValidate="txtConPw" ForeColor="Red"></asp:CompareValidator>
                            </div>   
                        </div>     
                    </div>
                    <hr />
                   <div class="form-group">                        
                       <asp:Button class="btn btn-primary d-grid gap-2 col-6 mx-auto btn-lg " ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />  
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
