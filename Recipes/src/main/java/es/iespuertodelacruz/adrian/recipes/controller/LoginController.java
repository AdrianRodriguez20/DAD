/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.adrian.recipes.controller;

import es.iespuertodelacruz.adrian.recipes.dao.ConnectionManagerDDBB;
import es.iespuertodelacruz.adrian.recipes.dao.UserDAO;
import es.iespuertodelacruz.adrian.recipes.model.User;
import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.Circle;
import javafx.stage.Modality;
import javafx.stage.Stage;
import javafx.stage.StageStyle;

/**
 * FXML Controller class
 *
 * @author Adrián Rodríguez Fuentes
 */
public class LoginController implements Initializable {

    @FXML
    private TextField txtUsername;
    @FXML
    private PasswordField txtPassword;
    @FXML
    private Button btnLogin;

    UserDAO userDAO = new UserDAO();
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
      
    }

    @FXML
    private void login(MouseEvent event) throws IOException {

        String username = txtUsername.getText();
        String password = txtPassword.getText();

        if (username != null && !username.trim().isEmpty()
                && password != null && !password.trim().isEmpty()) {
            User user = userDAO.findById(username);
            if (user != null) {
                if (user.getPassword().equals(password)) {
                    FXMLLoader loader = new FXMLLoader(getClass().getResource("/fxml/Home.fxml"));
                    Parent root = loader.load();
                    Scene scene = new Scene(root);
                    
                    Stage stage = new Stage();
                    stage.initModality(Modality.APPLICATION_MODAL);
                    stage.initStyle(StageStyle.UNDECORATED);
                    stage.setScene(scene);
                    
                    HomeController controller = loader.getController();
                    controller.controlRole(user.getRole());
                        
                    stage.show();
                } else {
                    txtPassword.setStyle("-fx-border-color:#FF0000");
                  
                }
            } else {
                txtUsername.setStyle("-fx-border-color:#FF0000");
              
            }
        }
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

}
