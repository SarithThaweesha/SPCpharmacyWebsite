<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminSearchD.aspx.cs" Inherits="login.AdminSearchD" %>
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
                                    <img src="imgs/drgst.png" />
                                </center>
                            </div>
                        </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Search Drug Stock</h3>
                                   <a href="OrderDrug.aspx"><b></b>Click here to order Drug<b></b></a><br /><br /> 
                            </center>
                        </div>     
                    </div>
                        <div class="row">
                        <div class="col">
                            <label>Drug ID</label>
                            <div class="form-group">
                                <asp:TextBox  CssClass="form-control" ID="txtSearch" runat="server" placeholder="D.."></asp:TextBox>
                               
                            </div>          
                        </div> 
                            <div class="col">
                                 <asp:Button Class="btn btn-lg btn-primary col-9 " ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"   /> 
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
                            <asp:GridView class="table table-hover table-bordered" ID="gridDrg" runat="server"></asp:GridView> 
                        </div>     
                    </div>     
                              
            </div>
        </div>
        
        <a href="SPC_AdminHome.aspx">Back to Admin home page</a><br /><br />
         </div>
</div>
        
        </div>
</asp:Content>
