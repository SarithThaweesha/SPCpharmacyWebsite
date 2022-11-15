<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="supplierLogin.aspx.cs" Inherits="login.supplierLogin" %>
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
                                    <img src="imgs/supplier.jpg" />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Supplier Login</h3>
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
                            <label>User Name</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtStaffName" runat="server" placeholder="UserName"></asp:TextBox>
                            </div>
                            
                        </div>     
                    </div>
                         <div class="row">
                        <div class="col">
                            <label>Password</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="TextBox1" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                            </div>   
                        </div>     
                    </div>
                    <hr />
                   <div class="form-group">                        
                       <asp:Button class="btn btn-primary d-grid gap-2 col-6 mx-auto btn-lg " ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />                  
                   </div>             
            </div>
        </div>
                <a href="supplierRegister.aspx">Click here to Register if you haven't..</a><br /><br />
    </div>
   </div>
  </div>
</asp:Content>
