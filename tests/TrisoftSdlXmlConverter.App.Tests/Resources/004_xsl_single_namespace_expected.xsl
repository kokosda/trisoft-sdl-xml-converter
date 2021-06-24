<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html title="SDL Trisoft">
            <body>
                <h2>My CD Collection</h2>
                <table border="1">
                    <tr title="SDL Trisoft">
                        <th style="text-align:left">SDL Trisoft</th>
                        <th style="text-align:left">SDL</th>
                    </tr>
                    <xsl:for-each select="catalog/cd">
                        <tr>
                            <td title="SDL Trisoft"><xsl:value-of select="title"/></td>
                            <td><xsl:value-of select="artist"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet> 