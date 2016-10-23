<%@ Page Title="" Language="C#" MasterPageFile="~/TestAdmin.Master" AutoEventWireup="true" CodeBehind="TAHome.aspx.cs" Inherits="Team2.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <!--carousel-->
    <div id="bodycarousel">
        <div class="container">
            <div class="carousel slide article-slide" id="myCarousel">
                <div class="carousel-inner cont-slider">
                    <div class="item active">
                        <img src="../images/image03.jpg">
                    </div>
                    <div class="item">
                        <img src="../images/image02.jpg">
                    </div>
                    <div class="item">
                        <img src="../images/image04.jpg">
                    </div>
                    <div class="item">
                        <img src="../images/image01.jpg">
                    </div>
                </div>
                 <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>
                <!-- Left and right controls -->
                <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
           

            <script>
                $('#myCarousel').carousel({
                    interval: 4000
                });
            </script>
        </div>
    </div>
    <br />
    <!--what we do -->
    <div class="container">
        <div class="jumbotron">
            <h1 style="color:#dd4814 !important">Our Vision</h1>
            <p>To ensure that every student in any corner of India gets an equal opportunity to build a career.</p>
        </div>
    </div>



    <div class="container">
        <div class="row">
            <div class="col-lg-4">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h3 class="panel-title">What is Recruitment?</h3>
                    </div>
                    <div class="panel-body">
                        <div class="col-lg-12 embed-responsive embed-responsive-16by9">
                            Recruitment Process
               <iframe width="640" height="390" src="https://www.youtube.com/embed/SYwUfCCMHvk" frameborder="0" allowfullscreen></iframe>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h3 class="panel-title">Online Recruitment Process</h3>
                    </div>
                    <div class="panel-body">
                        <div class="col-lg-12 embed-responsive embed-responsive-16by9">
                            Online Recruitment Process
               <iframe width="640" height="390" src="https://www.youtube.com/embed/N-3j8fWMyE8" frameborder="0" allowfullscreen></iframe>
                           </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h3 class="panel-title">HR Tips</h3>
                    </div>
                    <div class="panel-body">
                        <div class="col-lg-12 embed-responsive embed-responsive-16by9">
                           HR Tips and Online Recrutiment
                      <iframe width="640" height="390" src="https://www.youtube.com/embed/Da8HSLHBqLU" frameborder="0" allowfullscreen></iframe>

                           </div>
                    </div>
                </div>
            </div>

        </div>
      
</asp:Content>

