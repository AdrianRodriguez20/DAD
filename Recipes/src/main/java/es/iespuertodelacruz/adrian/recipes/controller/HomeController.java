/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.controller;

import com.jfoenix.controls.JFXButton;
import com.jfoenix.controls.JFXTextArea;
import de.jensd.fx.glyphs.fontawesome.FontAwesomeIconView;
import es.iespuertodelacruz.adrian.recipes.dao.RecipeDAO;
import es.iespuertodelacruz.adrian.recipes.dao.UserDAO;
import es.iespuertodelacruz.adrian.recipes.model.Recipe;

import java.awt.*;

import java.io.File;
import java.io.IOException;
import java.net.URL;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;

import es.iespuertodelacruz.adrian.recipes.model.User;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.chart.PieChart;
import javafx.scene.chart.StackedBarChart;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.image.ImageView;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.VBox;
import javafx.stage.Modality;
import javafx.stage.Stage;
import javafx.scene.image.Image;
import javafx.scene.shape.Circle;

/**
 * FXML Controller class
 *
 * @author Adrián Rodríguez Fuentes
 */
public class HomeController implements Initializable {

    @FXML
    private VBox panelScroll;
    RecipeDAO recipeDAO = new RecipeDAO();
    @FXML
    private javafx.scene.control.TextField txtSearch;
    @FXML
    private Button btnSearch;
    @FXML
    private FontAwesomeIconView btnAdd;
    @FXML
    private JFXButton btnUserManagement;
    @FXML
    private JFXButton btnPutNotes;
    @FXML
    private Circle btnMinimize;
    @FXML
    private Circle btnClose;
    @FXML
    private Circle btnMaximize;

    /**
     * Initializes the controller class.
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        refreshNodes(recipeDAO.findAll());
    }

    private void refreshNodes(ArrayList<Recipe> recipes) {
        panelScroll.getChildren().clear();
        Node[] nodes = new Node[recipes.size()];

        for (int i = 0; i < recipes.size(); i++) {
            try {
                //cargar preview de la receta
                nodes[i] = (Node) FXMLLoader.load(getClass().getResource("/fxml/PreviewRecipe.fxml"));

                Label txtTitle = (Label) nodes[i].lookup("#txtTitle");
                txtTitle.setText(recipes.get(i).getTitle());

                Label txtPreparationTime = (Label) nodes[i].lookup("#txtPreparationTime");
                txtPreparationTime.setText(recipes.get(i).getPreparationTime() + "");

                Label txtAuthor = (Label) nodes[i].lookup("#txtAuthor");
                txtAuthor.setText(recipes.get(i).getAuthor());

                Label txtNumberDiners = (Label) nodes[i].lookup("#txtNumberDiners");
                txtNumberDiners.setText(recipes.get(i).getNumberDiners() + "");

                Label txtTypeRecipe = (Label) nodes[i].lookup("#txtTypeRecipe");
                txtTypeRecipe.setText(recipes.get(i).getTypeRecipe());

                ImageView imgRecipe = (ImageView) nodes[i].lookup("#imgRecipe");
                if (recipes.get(i).getImage().contains("http")) {
                    imgRecipe.setImage(new javafx.scene.image.Image(recipes.get(i).getImage()));
                } else {
                    imgRecipe.setImage(new javafx.scene.image.Image(new File(recipes.get(i).getImage()).toURI().toString()));
                }

                Button btnDelete = (Button) nodes[i].lookup("#btnDelete");
                btnDelete.setOnAction((ActionEvent event) -> {
                    recipeDAO.delete(txtTitle.getText());

                });

                Button btnEdit = (Button) nodes[i].lookup("#btnEdit");
                btnEdit.setOnAction((ActionEvent event) -> {
                    try {
                        Recipe recipe = recipeDAO.findById(txtTitle.getText());

                        FXMLLoader loader = new FXMLLoader(getClass().getResource("/fxml/UpdateRecipe.fxml"));
                        Parent root = loader.load();
                        Scene scene = new Scene(root);

                        Stage stage = new Stage();
                        stage.initModality(Modality.APPLICATION_MODAL);
                        stage.setScene(scene);

                        UpdateRecipeController controller = loader.getController();
                        controller.setRecipe(recipe);
                        stage.show();

                    } catch (IOException ex) {
                        Logger.getLogger(HomeController.class.getName()).log(Level.SEVERE, null, ex);
                    }

                });
                //Cargar más información de la receta
                Button btnViewRecipe = (Button) nodes[i].lookup("#btnViewMore");
                btnViewRecipe.setOnAction((ActionEvent event) -> {
                    try {
                        Node node = (Node) FXMLLoader.load(getClass().getResource("/fxml/Recipe.fxml"));
                        panelScroll.getChildren().clear();

                        Recipe recipe = recipeDAO.findById(txtTitle.getText());

                        Label lblTitle = (Label) node.lookup("#txtTitle");
                        lblTitle.setText(recipe.getTitle());

                        Label lblPreparationTime = (Label) node.lookup("#txtPreparationTime");
                        lblPreparationTime.setText(recipe.getPreparationTime() + "");

                        Label lblAuthor = (Label) node.lookup("#txtAuthor");
                        lblAuthor.setText(recipe.getAuthor());

                        Label lblNumberDiners = (Label) node.lookup("#txtNumberDiners");
                        lblNumberDiners.setText(recipe.getNumberDiners() + "");

                        Label lblTypeRecipe = (Label) node.lookup("#txtTypeRecipe");
                        lblTypeRecipe.setText(recipe.getTypeRecipe());

                        ImageView imgRecipe2 = (ImageView) node.lookup("#imgRecipe");

                        if (recipe.getImage().contains("http")) {
                            imgRecipe2.setImage(new javafx.scene.image.Image(recipe.getImage()));
                        } else {
                            imgRecipe2.setImage(new javafx.scene.image.Image(new File(recipe.getImage()).toURI().toString()));
                        }

                        JFXTextArea lblIngredients = (JFXTextArea) node.lookup("#txtIngredients");
                        String ingredients = "";
                        for (int j = 0; j < recipe.getIngredients().size(); j++) {
                            ingredients += recipe.getIngredients().get(j) + "\n";
                        }
                        lblIngredients.setText(ingredients);

                        JFXTextArea lblSteps = (JFXTextArea) node.lookup("#txtSteps");
                        String steps = "";
                        for (int j = 0; j < recipe.getSteps().size(); j++) {
                            steps += recipe.getSteps().get(j) + "\n";
                        }
                        lblSteps.setText(steps);

                        Label lblCalories = (Label) node.lookup("#txtCalories");
                        lblCalories.setText(recipe.getCalories() + "");

                        ImageView btnReturn = (ImageView) node.lookup("#btnReturn");
                        btnReturn.setOnMouseClicked((MouseEvent event1) -> {
                            refreshNodes(recipeDAO.findAll());
                        });

                        panelScroll.getChildren().add(node);

                    } catch (IOException ex) {
                        Logger.getLogger(HomeController.class.getName()).log(Level.SEVERE, null, ex);
                    }
                });
                panelScroll.getChildren().add(nodes[i]);

            } catch (IOException ex) {
                Logger.getLogger(HomeController.class.getName()).log(Level.SEVERE, null, ex);
            }
        }

    }

    @FXML
    private void goInit(MouseEvent event) {
        refreshNodes(recipeDAO.findAll());
    }

    @FXML
    private void search(MouseEvent event) {

        panelScroll.getChildren().clear();
        refreshNodes(recipeDAO.findByTitle("%" + txtSearch.getText() + "%"));

    }

    @FXML
    private void add(MouseEvent event) {

        try {
            FXMLLoader loader = new FXMLLoader(getClass().getResource("/fxml/SaveRecipe.fxml"));
            Parent root = loader.load();
            Scene scene = new Scene(root);

            Stage stage = new Stage();
            stage.initModality(Modality.APPLICATION_MODAL);
            stage.setScene(scene);
            stage.show();
        } catch (IOException ex) {
            Logger.getLogger(HomeController.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @FXML
    private void showGraphics(MouseEvent event) throws IOException {
        panelScroll.getChildren().clear();
        Node node = (Node) FXMLLoader.load(getClass().getResource("/fxml/Statistics.fxml"));
        PieChart graphicCalories = (PieChart) node.lookup("#graphicCalories");
        graphicCalories.setTitle("Calorias por receta");
        ObservableList<PieChart.Data> pieChartData = FXCollections.observableArrayList();
        for (Recipe recipe : recipeDAO.findAll()) {
            PieChart.Data data = new PieChart.Data(recipe.getTitle(), recipe.getCalories());
            pieChartData.add(data);
        }
        graphicCalories.setData(pieChartData);

        StackedBarChart graphicTypeRecipe = (StackedBarChart) node.lookup("#graphicTypeRecipe");
        graphicTypeRecipe.setTitle("Tipos de Recetas");
        StackedBarChart.Series<String, Number> type = new StackedBarChart.Series<>();
        recipeDAO.getTypeRecipeCount().forEach((k, v) -> {
            type.getData().add(new StackedBarChart.Data<>(k, v));
        });

        graphicTypeRecipe.getData().addAll(type);
        panelScroll.getChildren().add(node);

    }

    public void crudTableView() throws IOException {
        panelScroll.getChildren().clear();
        Node node = (Node) FXMLLoader.load(getClass().getResource("/fxml/UserManagement.fxml"));
        TableView userManagementTableView = (TableView) node.lookup("#userManagementTableView");
        UserDAO userDAO = new UserDAO();

        TableColumn<User, String> column1 = new TableColumn<>("Usuario");
        column1.setCellValueFactory(new PropertyValueFactory<>("username"));

        TableColumn<User, String> column2 = new TableColumn<>("Contraseña");
        column2.setCellValueFactory(new PropertyValueFactory<>("password"));

        TableColumn<User, String> column3 = new TableColumn<>("Rol");
        column3.setCellValueFactory(new PropertyValueFactory<>("role"));

        userManagementTableView.setColumnResizePolicy(TableView.CONSTRAINED_RESIZE_POLICY);
        column1.setMaxWidth(1f * Integer.MAX_VALUE * 50); // 50% width
        column2.setMaxWidth(1f * Integer.MAX_VALUE * 30); // 30% width
        column3.setMaxWidth(1f * Integer.MAX_VALUE * 20); // 20% width

        userManagementTableView.getColumns().add(column1);
        userManagementTableView.getColumns().add(column2);
        userManagementTableView.getColumns().add(column3);

        for (User user : userDAO.findAll()) {
            userManagementTableView.getItems().add(user);
        }

        Button btnSave = (Button) node.lookup("#btnSave");
        btnSave.setOnAction((ActionEvent event1) -> {
            TextField txtName = (TextField) node.lookup("#txtName");
            TextField txtPassword = (TextField) node.lookup("#txtPassword");
            TextField txtRole = (TextField) node.lookup("#txtRole");

            String username = txtName.getText();
            String password = txtPassword.getText();
            String role = txtRole.getText();

            if (username != null && !username.trim().isEmpty() && password != null && !password.trim().isEmpty() && role != null && !role.trim().isEmpty()) {
                User user = new User(username, password, role);
                if (userDAO.findById(username) != null) {
                    try {
                        userDAO.update(user);
                        crudTableView();
                    } catch (IOException ex) {
                        Logger.getLogger(HomeController.class.getName()).log(Level.SEVERE, null, ex);
                    }
                } else {
                    try {
                        userDAO.save(user);
                        crudTableView();
                    } catch (IOException ex) {
                        Logger.getLogger(HomeController.class.getName()).log(Level.SEVERE, null, ex);
                    }
                }
            }
        });
        Button btnEditUser = (Button) node.lookup("#btnEditUser");
        btnEditUser.setOnAction((ActionEvent event1) -> {

            TextField txtName = (TextField) node.lookup("#txtName");
            TextField txtPassword = (TextField) node.lookup("#txtPassword");
            TextField txtRole = (TextField) node.lookup("#txtRole");

            User user = (User) userManagementTableView.getSelectionModel().getSelectedItem();

            txtName.setText(user.getUsername());
            txtPassword.setText(user.getPassword());
            txtRole.setText(user.getRole());

        });

        Button btnDeleteUser = (Button) node.lookup("#btnDeleteUser");
        btnDeleteUser.setOnAction((ActionEvent event1) -> {

         
                User user = (User) userManagementTableView.getSelectionModel().getSelectedItem();
           try {    
                userDAO.delete(user.getUsername());
                crudTableView();
            } catch (IOException ex) {
                Logger.getLogger(HomeController.class.getName()).log(Level.SEVERE, null, ex);
            }
        });

        panelScroll.getChildren().add(node);
    }

    @FXML
    private void UserManagement(MouseEvent event) throws IOException {
       crudTableView();
    }

    @FXML
    private void minimize(MouseEvent event) {
            Stage stage = (Stage) btnMinimize.getScene().getWindow();
            stage.setIconified(true);
    }

    @FXML
    private void close(MouseEvent event) {
         System.exit(0);
    }

    @FXML
    private void maximize(MouseEvent event) {
     Stage stage = (Stage)  btnMaximize.getScene().getWindow();
     stage.setMaximized(true);
    }

    void controlRole(String role) {
        if (role.equals("estudiante")){
                btnUserManagement.setVisible(false);
                btnPutNotes.setVisible(false);

        }
    }

}
