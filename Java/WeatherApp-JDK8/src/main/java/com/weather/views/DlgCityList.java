/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.weather.views;

import com.weather.controller.DlgCityListController;
import com.weather.pojo.Configuration;
import java.awt.Cursor;
import java.awt.Point;
import java.awt.Toolkit;
import java.io.FileNotFoundException;
import java.net.URL;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import rojerusan.RSAnimation;

/**
 *
 * @author Wong
 */
public class DlgCityList extends javax.swing.JDialog implements Runnable {

    /**
     * Creates new form DlgCityList
     */
    private DlgCityListController dlg;
    private WeatherMain wMain = wMain = new WeatherMain();
    private ExecutorService executor = Executors.newSingleThreadExecutor();
    private boolean btnSelected = false;

    public DlgCityList(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        executor.execute(this);
        initComponents();
        setAppIcon();
        setCursor();
    }

    private void setAppIcon() {
        URL url = getClass().getResource("/com/weather/images/icono.png");
        ImageIcon icon = new ImageIcon(url);
        this.setIconImage(icon.getImage());
    }

    private void setCursor() {
        Cursor cursor;
        ImageIcon image = new ImageIcon(getClass().getResource("/com/weather/images/cursorAmarillo.png"));
        Toolkit t = Toolkit.getDefaultToolkit();
        cursor = t.createCustomCursor(image.getImage(), new Point(1, 1), "Cursor");
        this.setCursor(cursor);
    }

    public boolean isbtnSelected() {
        return btnSelected;
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {
        java.awt.GridBagConstraints gridBagConstraints;

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        btnAccept = new RSMaterialComponent.RSButtonMaterialGradientOne();
        jLabel2 = new javax.swing.JLabel();
        rSButtonMaterialGradientOne3 = new RSMaterialComponent.RSButtonMaterialGradientOne();
        jScrollPane2 = new javax.swing.JScrollPane();
        lstCity = new javax.swing.JList<>();
        jPanel2 = new javax.swing.JPanel();
        jLabel3 = new javax.swing.JLabel();
        rSButtonMaterialGradientOne1 = new RSMaterialComponent.RSButtonMaterialGradientOne();
        txtSearch = new javax.swing.JFormattedTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Select a city");
        setResizable(false);
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosed(java.awt.event.WindowEvent evt) {
                formWindowClosed(evt);
            }
        });
        addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                formKeyPressed(evt);
            }
        });

        jPanel1.setBackground(new java.awt.Color(71, 71, 73));
        jPanel1.setLayout(new java.awt.GridBagLayout());

        jLabel1.setFont(new java.awt.Font("Berlin Sans FB Demi", 1, 16)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 255, 255));
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Select a city here:");
        gridBagConstraints = new java.awt.GridBagConstraints();
        gridBagConstraints.gridx = 0;
        gridBagConstraints.gridy = 0;
        gridBagConstraints.gridheight = 2;
        gridBagConstraints.ipadx = 9;
        gridBagConstraints.ipady = 11;
        gridBagConstraints.anchor = java.awt.GridBagConstraints.NORTHWEST;
        gridBagConstraints.insets = new java.awt.Insets(12, 21, 0, 0);
        jPanel1.add(jLabel1, gridBagConstraints);

        btnAccept.setText("Accept");
        btnAccept.setColorPrimario(new java.awt.Color(0, 153, 0));
        btnAccept.setColorPrimarioHover(new java.awt.Color(0, 153, 0));
        btnAccept.setColorSecundario(new java.awt.Color(0, 51, 51));
        btnAccept.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAcceptActionPerformed(evt);
            }
        });
        gridBagConstraints = new java.awt.GridBagConstraints();
        gridBagConstraints.gridx = 1;
        gridBagConstraints.gridy = 3;
        gridBagConstraints.ipadx = 62;
        gridBagConstraints.ipady = 11;
        gridBagConstraints.anchor = java.awt.GridBagConstraints.NORTHWEST;
        gridBagConstraints.insets = new java.awt.Insets(18, 63, 15, 0);
        jPanel1.add(btnAccept, gridBagConstraints);

        jLabel2.setFont(new java.awt.Font("Berlin Sans FB Demi", 1, 16)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(255, 255, 255));
        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel2.setText("10 MAX");
        gridBagConstraints = new java.awt.GridBagConstraints();
        gridBagConstraints.gridx = 2;
        gridBagConstraints.gridy = 0;
        gridBagConstraints.ipadx = 15;
        gridBagConstraints.ipady = 5;
        gridBagConstraints.anchor = java.awt.GridBagConstraints.NORTHWEST;
        gridBagConstraints.insets = new java.awt.Insets(12, 76, 0, 22);
        jPanel1.add(jLabel2, gridBagConstraints);

        rSButtonMaterialGradientOne3.setText("Cancel");
        rSButtonMaterialGradientOne3.setColorPrimario(new java.awt.Color(153, 0, 0));
        rSButtonMaterialGradientOne3.setColorPrimarioHover(new java.awt.Color(153, 0, 0));
        rSButtonMaterialGradientOne3.setColorSecundario(new java.awt.Color(204, 0, 0));
        rSButtonMaterialGradientOne3.setColorSecundarioHover(new java.awt.Color(204, 0, 0));
        rSButtonMaterialGradientOne3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rSButtonMaterialGradientOne3ActionPerformed(evt);
            }
        });
        gridBagConstraints = new java.awt.GridBagConstraints();
        gridBagConstraints.gridx = 2;
        gridBagConstraints.gridy = 3;
        gridBagConstraints.ipadx = 54;
        gridBagConstraints.ipady = 11;
        gridBagConstraints.anchor = java.awt.GridBagConstraints.NORTHWEST;
        gridBagConstraints.insets = new java.awt.Insets(18, 18, 15, 22);
        jPanel1.add(rSButtonMaterialGradientOne3, gridBagConstraints);

        try{
            lstCity.setModel(dlg.getListModel());
        }catch(Exception e){
            e.getMessage();
        }
        lstCity.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                lstCityMouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(lstCity);

        gridBagConstraints = new java.awt.GridBagConstraints();
        gridBagConstraints.gridx = 0;
        gridBagConstraints.gridy = 2;
        gridBagConstraints.gridwidth = 3;
        gridBagConstraints.fill = java.awt.GridBagConstraints.BOTH;
        gridBagConstraints.ipadx = 456;
        gridBagConstraints.ipady = 195;
        gridBagConstraints.anchor = java.awt.GridBagConstraints.NORTHWEST;
        gridBagConstraints.weightx = 1.0;
        gridBagConstraints.weighty = 1.0;
        gridBagConstraints.insets = new java.awt.Insets(12, 21, 0, 22);
        jPanel1.add(jScrollPane2, gridBagConstraints);

        getContentPane().add(jPanel1, java.awt.BorderLayout.CENTER);

        jPanel2.setBackground(new java.awt.Color(233, 109, 73));
        jPanel2.setLayout(new java.awt.GridBagLayout());

        jLabel3.setFont(new java.awt.Font("Berlin Sans FB Demi", 1, 16)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 255, 255));
        jLabel3.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel3.setText("Search a city here: ");
        gridBagConstraints = new java.awt.GridBagConstraints();
        gridBagConstraints.gridx = 0;
        gridBagConstraints.gridy = 0;
        gridBagConstraints.ipadx = 15;
        gridBagConstraints.anchor = java.awt.GridBagConstraints.NORTHWEST;
        gridBagConstraints.insets = new java.awt.Insets(14, 21, 0, 0);
        jPanel2.add(jLabel3, gridBagConstraints);

        rSButtonMaterialGradientOne1.setText("Search");
        rSButtonMaterialGradientOne1.setColorPrimario(new java.awt.Color(0, 153, 0));
        rSButtonMaterialGradientOne1.setColorPrimarioHover(new java.awt.Color(0, 153, 0));
        rSButtonMaterialGradientOne1.setColorSecundario(new java.awt.Color(0, 51, 51));
        rSButtonMaterialGradientOne1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rSButtonMaterialGradientOne1ActionPerformed(evt);
            }
        });
        gridBagConstraints = new java.awt.GridBagConstraints();
        gridBagConstraints.gridx = 2;
        gridBagConstraints.gridy = 1;
        gridBagConstraints.ipadx = 56;
        gridBagConstraints.ipady = 6;
        gridBagConstraints.anchor = java.awt.GridBagConstraints.NORTHWEST;
        gridBagConstraints.insets = new java.awt.Insets(12, 58, 6, 18);
        jPanel2.add(rSButtonMaterialGradientOne1, gridBagConstraints);

        txtSearch.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusGained(java.awt.event.FocusEvent evt) {
                txtSearchFocusGained(evt);
            }
        });
        txtSearch.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtSearchActionPerformed(evt);
            }
        });
        gridBagConstraints = new java.awt.GridBagConstraints();
        gridBagConstraints.gridx = 0;
        gridBagConstraints.gridy = 1;
        gridBagConstraints.gridwidth = 2;
        gridBagConstraints.ipadx = 280;
        gridBagConstraints.ipady = 7;
        gridBagConstraints.anchor = java.awt.GridBagConstraints.NORTHWEST;
        gridBagConstraints.insets = new java.awt.Insets(12, 21, 6, 0);
        jPanel2.add(txtSearch, gridBagConstraints);

        getContentPane().add(jPanel2, java.awt.BorderLayout.PAGE_START);

        setSize(new java.awt.Dimension(534, 498));
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnAcceptActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAcceptActionPerformed
        // TODO add your handling code here:
        btnSelected = true;
        Configuration.cityList = lstCity.getSelectedValuesList();
        
        wMain.getBtnAnterior().setEnabled(true);
        wMain.getBtnEliminar().setEnabled(true);
        wMain.getBtnSiguiente().setEnabled(true);

        RSAnimation.setSubir((int) this.getLocationOnScreen().getY(), -500, 1, 4, this);
        try {
            Thread.sleep(600);
        } catch (InterruptedException ex) {
            Logger.getLogger(DlgCityList.class.getName()).log(Level.SEVERE, null, ex);
        }
        this.dispose();

    }//GEN-LAST:event_btnAcceptActionPerformed

    private void rSButtonMaterialGradientOne3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rSButtonMaterialGradientOne3ActionPerformed
        // TODO add your handling code here:
        RSAnimation.setSubir((int) this.getLocationOnScreen().getY(), -500, 1, 4, this);
        try {
            Thread.sleep(600);
        } catch (InterruptedException ex) {
            Logger.getLogger(DlgCityList.class.getName()).log(Level.SEVERE, null, ex);
        }
        this.dispose();
    }//GEN-LAST:event_rSButtonMaterialGradientOne3ActionPerformed

    private void formWindowClosed(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosed
        // TODO add your handling code here:
        executor.shutdownNow();
    }//GEN-LAST:event_formWindowClosed

    private void lstCityMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_lstCityMouseClicked
        
    }//GEN-LAST:event_lstCityMouseClicked

    private void rSButtonMaterialGradientOne1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rSButtonMaterialGradientOne1ActionPerformed
        // TODO add your handling code here:
        btnSelected = true;
        String texto = txtSearch.getText() + ", NI";
        
        try {
            if(dlg.getNICities().contains(texto)){
                Configuration.cityList.add(texto);
            }else{
                JOptionPane.showMessageDialog(this,texto+" NO exist!","Warning", JOptionPane.WARNING_MESSAGE);
                return;
            }
        } catch (FileNotFoundException ex) {
            Logger.getLogger(DlgCityList.class.getName()).log(Level.SEVERE, null, ex);
        }
        wMain.getBtnAnterior().setEnabled(true);
        wMain.getBtnEliminar().setEnabled(true);
        wMain.getBtnSiguiente().setEnabled(true);

        RSAnimation.setSubir((int) this.getLocationOnScreen().getY(), -500, 1, 4, this);
        try {
            Thread.sleep(600);
        } catch (InterruptedException ex) {
            Logger.getLogger(DlgCityList.class.getName()).log(Level.SEVERE, null, ex);
        }
        this.dispose();
    }//GEN-LAST:event_rSButtonMaterialGradientOne1ActionPerformed

    private void txtSearchActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtSearchActionPerformed
        // TODO add your handling code here:
        
    }//GEN-LAST:event_txtSearchActionPerformed

    private void txtSearchFocusGained(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_txtSearchFocusGained
        // TODO add your handling code here:
        lstCity.clearSelection();
    }//GEN-LAST:event_txtSearchFocusGained

    private void formKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_formKeyPressed
        
    }//GEN-LAST:event_formKeyPressed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(DlgCityList.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(DlgCityList.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(DlgCityList.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(DlgCityList.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(() -> {
            DlgCityList dialog = new DlgCityList(new javax.swing.JFrame(), true);
            dialog.addWindowListener(new java.awt.event.WindowAdapter() {
                @Override
                public void windowClosing(java.awt.event.WindowEvent e) {
                    System.exit(0);
                }
            });
            dialog.setVisible(true);
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private RSMaterialComponent.RSButtonMaterialGradientOne btnAccept;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JList<String> lstCity;
    private RSMaterialComponent.RSButtonMaterialGradientOne rSButtonMaterialGradientOne1;
    private RSMaterialComponent.RSButtonMaterialGradientOne rSButtonMaterialGradientOne3;
    private javax.swing.JFormattedTextField txtSearch;
    // End of variables declaration//GEN-END:variables

    @Override
    public void run() {
        dlg = new DlgCityListController();
    }
}
