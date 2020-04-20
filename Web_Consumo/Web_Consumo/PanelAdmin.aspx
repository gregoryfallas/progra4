﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanelAdmin.aspx.cs" Inherits="Web_Consumo.PanelAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <meta http-equiv="x-ua-compatible" content="ie=edge"/>
  <script src="https://kit.fontawesome.com/3287ad1c4d.js"></script>
      <!-- Font Awesome Icons -->
  <link rel="stylesheet" href="css/all.min.css"/>
  <link rel="stylesheet" href="css/style.css"/>
  <!-- IonIcons -->
  <link rel="stylesheet" href="http://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"/>
  <!-- Theme style -->
  <link rel="stylesheet" href="css/adminlte.min.css"/>
  <!-- Google Font: Source Sans Pro -->
  <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet"/>
</head>
<body class="hold-transition sidebar-mini">
    <div class="wrapper">
          <!-- Main Sidebar Container -->
  <aside class="main-sidebar sidebar-dark-primary elevation-4">
    <!-- Brand Logo -->
    <a href="index3.html" class="brand-link">
      <img src="img/footer_logo.png" alt="Logo"
           style="opacity: .8"/>
    </a>

    <!-- Sidebar -->
    <div class="sidebar">


      <!-- Menu lateral -->
      <nav class="mt-2">
        <ul class="nav nav-pills nav-sidebar flex-column" data-widget="treeview" role="menu" data-accordion="false">
          <!-- Menu Administracion vuelos -->
             <li class="nav-header">Administracion de Vuelos</li>
          <li class="nav-item">
            <a href="pages/calendar.html" class="nav-link">
              <i class="fas fa-plane"></i>
              <p>
                 Aviones
              </p>
            </a>
          </li>
          <li class="nav-item">
            <a href="pages/gallery.html" class="nav-link">
              <i class="fas fa-plane-departure"></i>
              <p>
                 Vuelos
              </p>
            </a>
          </li>
             <li class="nav-item">
            <a href="pages/gallery.html" class="nav-link">
              <i class="fas fa-map-marked-alt"></i>
              <p>
                Destinos
              </p>
            </a>
          </li>
             <li class="nav-item">
            <a href="pages/gallery.html" class="nav-link">
              <i class="fas fa-globe-americas"></i>
              <p>
                Paises
              </p>
            </a>
          </li>
             <li class="nav-item">
            <a href="pages/gallery.html" class="nav-link">
              <i class="fas fa-plane"></i>
              <p>
                Categorias de vuelo
              </p>
            </a>
          </li>
             <li class="nav-item">
            <a href="pages/gallery.html" class="nav-link">
              <i class="fas fa-fighter-jet"></i>
              <p>
                Tipos de Aviones
              </p>
            </a>
          </li>

             <!-- Menu Empleados -->
             <li class="nav-header">Empleados</li>'
          <li class="nav-item">
            <a href="pages/calendar.html" class="nav-link">
              <i class="fas fa-address-card"></i>
              <p>
                Empleados
              </p>
            </a>
          </li>
          <li class="nav-item">
            <a href="pages/gallery.html" class="nav-link">
              <i class="fas fa-user"></i>
              <p>
                Usuarios
              </p>
            </a>
          </li>
               <li class="nav-item">
            <a href="pages/gallery.html" class="nav-link">
              <i class="fas fa-user-cog"></i>
              <p>
                Tipos de Empleado
              </p>
            </a>
          </li>

             <!-- Menu Clientes -->
             <li class="nav-header">Clientes</li>
          <li class="nav-item">
            <a href="pages/calendar.html" class="nav-link">
              <i class="fas fa-users"></i>
              <p>
                Clientes
              </p>
            </a>
          </li>
          <li class="nav-item">
            <a href="pages/gallery.html" class="nav-link">
              <i class="fas fa-users-cog"></i>
              <p>
                Tipos de Cliente
              </p>
            </a>
          </li>

            <!-- Menu desplegable configuracion -->
          <li class="nav-header">Configuracion</li>
          <li class="nav-item">
            <a href="pages/calendar.html" class="nav-link">
              <i class="fas fa-building"></i>
              <p>
                Aerolinea
              </p>
            </a>
          </li>
          <li class="nav-item">
            <a href="pages/gallery.html" class="nav-link">
              <i class="fas fa-info-circle"></i>
              <p>
                Estados
              </p>
            </a>
          </li>
                
                      
        </ul>
      </nav>
      <!-- /.sidebar-menu -->
    </div>
    <!-- /.sidebar -->
  </aside>
    </div>
<!-- REQUIRED SCRIPTS -->

<!-- jQuery -->
<script src="js/AdminPanel/jquery.min.js"></script>
<!-- Bootstrap -->
<script src="js/AdminPanel/bootstrap.bundle.min.js"></script>
<!-- AdminLTE -->
<script src="js/AdminPanel/adminlte.js"></script>
</body>

</html>
