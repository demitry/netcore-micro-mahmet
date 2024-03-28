# pgAdmin



https://www.postgresql.org/ftp/pgadmin/pgadmin4/v8.4/windows/





To connect to your Docker PostgreSQL database using pgAdmin, you'll need to follow these steps:

1. **Ensure Docker Container is Running**: First, make sure your Docker container with PostgreSQL is running. You should have created and started a Docker container with PostgreSQL using a command similar to `docker run --name my_postgres -e POSTGRES_PASSWORD=my_password -d postgres`.

2. **Determine Container IP Address**: Find out the IP address of your Docker container. You can do this by running `docker inspect <container_name_or_id>`, and then looking for the "IPAddress" field under the "NetworkSettings" section.

3. **Open pgAdmin**: Launch pgAdmin on your local machine. If you haven't installed pgAdmin yet, download and install it from the official website.

4. **Add New Server**: In pgAdmin, right-click on "Servers" and select "Create" -> "Server...".

5. **Fill in Connection Details**:
   
   - **General**: Enter a name for your server (e.g., My Docker PostgreSQL).
   - **Connection**: Enter the IP address of your Docker container in the "Host name/address" field. Use the default port 5432.
   - **Maintenance**: You can leave this section blank or fill in additional details as needed.
   - **SSL**: Unless you've specifically configured SSL for your PostgreSQL container, you can leave this section as default.
   - **Advanced**: Again, you can leave this section with default settings unless you have specific requirements.

6. **Save the Server Configuration**: Click on the "Save" button to save the server configuration.

7. **Connect to the Server**: Double-click on the server you just created in the pgAdmin dashboard to connect to it. You may be prompted to enter the password you set for the PostgreSQL container.

8. **Explore and Manage Databases**: Once connected, you should see the list of databases hosted on your Docker PostgreSQL instance. You can now explore, query, and manage these databases using pgAdmin.

By following these steps, you should be able to successfully connect to your Docker PostgreSQL database using pgAdmin.
