﻿<%@ Page Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" Inherits="Rock.Web.UI.RockPage" %>

<script runat="server">

    // keep code below to call base class init method

    /// <summary>
    /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
    protected override void OnPreRender( EventArgs e )
    {
        base.OnPreRender( e );
    }

</script>

<asp:Content ID="ctFeature" ContentPlaceHolderID="feature" runat="server">
    <style>
    .main-content {
        display: none;
    }

    .panel.panel-block {
                margin-bottom: 0;
                height: calc(100vh - 116px); /* Where 116px is the height of the header and footer */
                overflow-y: auto;
            }
</style>
                <!-- Ajax Error -->
            <div class="alert alert-danger ajax-error no-index" style="display:none">
                <p><strong>Error</strong></p>
                <span class="ajax-error-message"></span>
            </div>

            <div class="row">
                <div class="col-md-12">
                    <Rock:Zone Name="Feature" runat="server" />
                </div>
            </div>

            <div class="row py-3">
                <div class="col-md-12">
                    <Rock:Zone Name="Main" runat="server" />
                </div>
            </div>
</asp:Content>

<asp:Content ID="ctMain" ContentPlaceHolderID="main" runat="server">

            <div class="row">
                <div class="col-md-12">
                    <Rock:Zone Name="Section A" runat="server" />
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                    <Rock:Zone Name="Section B" runat="server" />
                </div>
                <div class="col-md-4">
                    <Rock:Zone Name="Section C" runat="server" />
                </div>
                <div class="col-md-4">
                    <Rock:Zone Name="Section D" runat="server" />
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <Rock:Zone Name="Section E" runat="server" />
                </div>
                <div class="col-md-6">
                    <Rock:Zone Name="Section F" runat="server" />
                </div>
            </div>
        <!-- End Content Area -->

</asp:Content>
