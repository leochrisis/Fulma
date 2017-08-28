module Fulma.Dispatcher.State

open Elmish
open Types

let init() =
    { Elements =
        { Box = Elements.Box.State.init ()
          Button = Elements.Button.State.init ()
          Content = Elements.Content.State.init ()
          Delete = Elements.Delete.State.init ()
          Icon = Elements.Icon.State.init ()
          Image = Elements.Image.State.init ()
          Progress = Elements.Progress.State.init ()
          Table = Elements.Table.State.init ()
          Tag = Elements.Tag.State.init ()
          Notification = Elements.Notification.State.init ()
          Title = Elements.Title.State.init () }
      Components =
        { Panel = Components.Panel.State.init ()
          Level = Components.Level.State.init ()
          Breadcrumb = Components.Breadcrumb.State.init ()
          Card = Components.Card.State.init ()
          Media = Components.Media.State.init ()
          Menu = Components.Menu.State.init ()
          Navbar = Components.Navbar.State.init ()
          Pagination = Components.Pagination.State.init ()
          Tabs = Components.Tabs.State.init ()
          Message = Components.Message.State.init () } }

let update msg model =
    match msg with
    | BoxMsg msg ->
        let (box, boxMsg) = Elements.Box.State.update msg model.Elements.Box
        { model with Elements =
                        { model.Elements with Box = box } }, Cmd.map BoxMsg boxMsg

    | ButtonMsg msg ->
        let (button, buttonMsg) = Elements.Button.State.update msg model.Elements.Button
        { model with Elements =
                        { model.Elements with Button = button } }, Cmd.map ButtonMsg buttonMsg

    | ContentMsg msg ->
        let (content, contentMsg) = Elements.Content.State.update msg model.Elements.Content
        { model with Elements =
                        { model.Elements with Content = content } }, Cmd.map ContentMsg contentMsg

    | DeleteMsg msg ->
        let (delete, deleteMsg) = Elements.Delete.State.update msg model.Elements.Delete
        { model with Elements =
                        { model.Elements with Delete = delete } }, Cmd.map DeleteMsg deleteMsg

    | IconMsg msg ->
        let (icon, iconMsg) = Elements.Icon.State.update msg model.Elements.Icon
        { model with Elements =
                        { model.Elements with Icon = icon } }, Cmd.map IconMsg iconMsg

    | ImageMsg msg ->
        let (image, imageMsg) = Elements.Image.State.update msg model.Elements.Image
        { model with Elements =
                        { model.Elements with Image = image } }, Cmd.map ImageMsg imageMsg

    | ProgressMsg msg ->
        let (progress, progressMsg) = Elements.Progress.State.update msg model.Elements.Progress
        { model with Elements =
                        { model.Elements with Progress = progress } }, Cmd.map ProgressMsg progressMsg

    | TableMsg msg ->
        let (table, tableMsg) = Elements.Table.State.update msg model.Elements.Table
        { model with Elements =
                        { model.Elements with Table = table } }, Cmd.map TableMsg tableMsg

    | TagMsg msg ->
        let (tag, tagMsg) = Elements.Tag.State.update msg model.Elements.Tag
        { model with Elements =
                        { model.Elements with Tag = tag } }, Cmd.map TagMsg tagMsg

    | TitleMsg msg ->
        let (title, titleMsg) = Elements.Title.State.update msg model.Elements.Title
        { model with Elements =
                        { model.Elements with Title = title } }, Cmd.map TitleMsg titleMsg

    | PanelMsg msg ->
        let (panel, panelMsg) = Components.Panel.State.update msg model.Components.Panel
        { model with Components =
                        { model.Components with Panel = panel } }, Cmd.map PanelMsg panelMsg

    | LevelMsg msg ->
        let (level, levelMsg) = Components.Level.State.update msg model.Components.Level
        { model with Components =
                        { model.Components with Level = level } }, Cmd.map LevelMsg levelMsg

    | BreadcrumbMsg msg ->
        let (breadcrumb, breadcrumbMsg) = Components.Breadcrumb.State.update msg model.Components.Breadcrumb
        { model with Components =
                        { model.Components with Breadcrumb = breadcrumb } }, Cmd.map BreadcrumbMsg breadcrumbMsg

    | CardMsg msg ->
        let (card, cardMsg) = Components.Card.State.update msg model.Components.Card
        { model with Components =
                        { model.Components with Card = card } }, Cmd.map CardMsg cardMsg

    | MediaMsg msg ->
        let (media, mediaMsg) = Components.Media.State.update msg model.Components.Media
        { model with Components =
                        { model.Components with Media = media } }, Cmd.map MediaMsg mediaMsg

    | MenuMsg msg ->
        let (menu, menuMsg) = Components.Menu.State.update msg model.Components.Menu
        { model with Components =
                        { model.Components with Menu = menu } }, Cmd.map MenuMsg menuMsg

    | MessageMsg msg ->
        let (message, messageMsg) = Components.Message.State.update msg model.Components.Message
        { model with Components =
                        { model.Components with Message = message } }, Cmd.map MessageMsg messageMsg

    | NavbarMsg msg ->
        let (navbar, navbarMsg) = Components.Navbar.State.update msg model.Components.Navbar
        { model with Components =
                        { model.Components with Navbar = navbar } }, Cmd.map NavbarMsg navbarMsg

    | PaginationMsg msg ->
        let (pagination, paginationMsg) = Components.Pagination.State.update msg model.Components.Pagination
        { model with Components =
                        { model.Components with Pagination = pagination } }, Cmd.map PaginationMsg paginationMsg

    | TabsMsg msg ->
        let (tabs, tabsMsg) = Components.Tabs.State.update msg model.Components.Tabs
        { model with Components =
                        { model.Components with Tabs = tabs } }, Cmd.map TabsMsg tabsMsg

    | NotificationMsg msg ->
        let (notification, notificationMsg) = Elements.Notification.State.update msg model.Elements.Notification
        { model with Elements =
                        { model.Elements with Notification = notification } }, Cmd.map NotificationMsg notificationMsg
